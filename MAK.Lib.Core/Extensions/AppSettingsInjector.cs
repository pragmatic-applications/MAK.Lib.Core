namespace Extensions;

/// <summary>
/// This type is used for providing generic run-time service registration for DI that want's to use AppSettings.json for configuration data.
/// </summary>
public static class AppSettingsInjector
{
    public static IServiceCollection InjectAppSettings<T>(this IServiceCollection services, IConfiguration configuration, string configurationSection) where T : class
    {
        if(string.IsNullOrEmpty(configurationSection))
        {
            configurationSection = typeof(T).Name;
        }

        var instance = Activator.CreateInstance<T>();
        new ConfigureFromConfigurationOptions<T>(configuration.GetSection(configurationSection)).Configure(instance);
        services.AddSingleton(instance);

        return services;
    }
}

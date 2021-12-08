namespace Interfaces;

public interface IService
{
    IServiceCollection AddServices(IServiceCollection services, IConfiguration configuration = null, string url = null);
}

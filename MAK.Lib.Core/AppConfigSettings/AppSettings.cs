namespace AppConfigSettings;

public class AppSettings
{
    public string WebRoot { get; set; }
    public AuthGoogle AuthGoogle { get; set; }
    public AuthFacebook AuthFacebook { get; set; }
    public EmailConfig EmailConfig { get; set; }
    public EmailData EmailData { get; set; }
    public StripeData StripeData { get; set; }
    public PageData PageData { get; set; }
    public DevMode DevMode { get; set; }
}

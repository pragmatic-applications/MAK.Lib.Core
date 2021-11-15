namespace AppConfigSettings;

public class EmailData
{
    public string EmailServerHostAdminUserName { get; set; }
    public string EmailServerHostAdminPassword { get; set; }
    public string EmailServerHost { get; set; }
    public bool IsSSL { get; set; }
    public int SmtpPort { get; set; }
    public string SmtpPort_Guide_Values_Backup { get; set; }
    public string RecipientEmailDeveloper { get; set; }
    public string ToDisplayNameDeveloper { get; set; }
    public string ToEmailAddressDeveloper { get; set; }
    public string ToEmailAddressOwnerClient { get; set; }
    public string ToDisplayNameOwnerClient { get; set; }
    public string RecipientEmailOwner { get; set; }
}

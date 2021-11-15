namespace Domain;

public record EmailInfo(string SmtpServer, string MailServerUserName, string MailServerUserPassword, string ToEmailAddress);

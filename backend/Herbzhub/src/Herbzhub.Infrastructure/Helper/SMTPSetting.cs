namespace Herbzhub.Infrastructure.Services;

public record SMTPSetting(string Host, int Port, string UserName, string Password);

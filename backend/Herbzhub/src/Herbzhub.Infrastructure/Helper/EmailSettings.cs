namespace Herbzhub.Infrastructure.Services;

public record EmailSettings(string DefaultFromEmail, SMTPSetting SMTPSetting);

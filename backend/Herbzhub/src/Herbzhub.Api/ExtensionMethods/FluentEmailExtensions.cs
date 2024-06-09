using System.Net.Mail;

namespace Herbzhub.Api.ExtensionMethods
{
    public static class FluentEmailExtensions
    {
        public static void AddFluentEmail(this IServiceCollection services,
            ConfigurationManager configuration)
        {
          
            var emailSettings = new EmailSettings();
            configuration.GetSection("EmailSettings").Bind(emailSettings);

            services.AddFluentEmail(emailSettings.DefaultFromEmail)
                    .AddSmtpSender(new SmtpClient
                    {
                        Host = emailSettings.SMTPSetting.Host,
                        Port = emailSettings.SMTPSetting.Port,
                        Credentials = new System.Net.NetworkCredential(emailSettings.SMTPSetting.UserName, emailSettings.SMTPSetting.Password),
                        EnableSsl = false // Set this according to your SMTP server requirements
                    });
        }


        }



    }

    public class EmailSettings
    {
        public string DefaultFromEmail { get; set; }
        public SMTPSetting SMTPSetting { get; set; }
    }

    public class SMTPSetting
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }



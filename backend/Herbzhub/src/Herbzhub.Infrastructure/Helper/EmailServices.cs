using System;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using FluentEmail.Core;

namespace Herbzhub.Infrastructure.Services;

public class EmailService
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<EmailService> _logger;
        private readonly IFluentEmail _fluentEmail;
        public EmailService(IConfiguration configuration, ILogger<EmailService> logger,IFluentEmail fluentEmail)
        {
            _configuration = configuration;
            _logger = logger;
            _fluentEmail = fluentEmail;
        }

        public async Task SendEmailAsync(string toEmail, string subject, string body, bool isHtml = false)
        {
            var email = _fluentEmail
                .To(toEmail)
                .Subject(subject)
                .Body(body, isHtml);

            await email.SendAsync();
        }

    public async Task SendForgotPasswordEmailAsync(string toEmail, string tokenUrl, string appUrl, string token, string logoPath)
        {
            var subject = "Reset Your Password";
            var body = ForgotPassword.GenerateHtmlMail(tokenUrl, appUrl, token,logoPath);

            await SendEmailAsync(toEmail, subject, body, isHtml: true);
        }
    }

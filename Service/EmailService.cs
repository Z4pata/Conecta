using System;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace Conecta.Service;
public class EmailService
{
    public async Task SendEmailAsync(string toEmail, string subject, string message)
    {

        var myEmail = Environment.GetEnvironmentVariable("EMAIL") ?? throw new InvalidOperationException("Email Not found");
        var appPassword = Environment.GetEnvironmentVariable("APP_PASSWORD") ?? throw new InvalidOperationException("Email Not found");

        var emailMessage = new MimeMessage();
        emailMessage.From.Add(new MailboxAddress("Conecta", myEmail));
        emailMessage.To.Add(new MailboxAddress("", toEmail));
        emailMessage.Subject = subject;

        emailMessage.Body = new TextPart("plain")
        {
            Text = message
        };

        using var client = new SmtpClient();
        try
        {
            await client.ConnectAsync("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
            await client.AuthenticateAsync(myEmail, appPassword);
            await client.SendAsync(emailMessage);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error sending email: {ex.Message}");
        }
        finally
        {
            await client.DisconnectAsync(true);
        }
    }
}

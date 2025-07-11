namespace DesignPatterns.Structural.Facade.Service.Smtp;

public class SmtpService
{
    public bool SendEmail(string client)
    {
        Console.WriteLine($"Sending email to {client}");
        Console.WriteLine("Email sent successfully.");
        return true;
    }
}
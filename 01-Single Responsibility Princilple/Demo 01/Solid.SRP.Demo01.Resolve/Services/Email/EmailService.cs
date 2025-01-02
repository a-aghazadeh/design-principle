namespace Solid.SRP.Demo01.Resolve;

public class EmailService : IEmailService
{
    public void EmailOrderConfirmation(string text)
    {
        Console.WriteLine($"Sended Email ... {text}");
    }
}

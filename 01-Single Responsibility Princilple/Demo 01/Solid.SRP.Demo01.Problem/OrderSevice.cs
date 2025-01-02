namespace Solid.SRP.Demo01.Problem;

public class OrderSevice : IOrderSevice
{
    public void AddToCart(string productName)
    {
         Console.WriteLine($"Added Product : {productName} To Cart. ");
    }

    public void CommitCart()
    {
       Console.WriteLine("Commit Cart");
    }

    public void EmailOrderConfirmation(string text)
    {
       Console.WriteLine($"Sended Email ... {text}");
    }

    public void RemoveFromCart(string productName)
    {
        Console.WriteLine($"Removed Product : {productName} From Cart. ");
    }

    public void SinginUser(string userName, string password)
    {
        Console.WriteLine($"User signed in : {userName}");
    }

    public void Singout()
    {
          Console.WriteLine($"User Singout");
    }

    public void SingupUser(string userName, string password,string confirmPassword)
    {
        Console.WriteLine($"User signed up : {userName}");
    }

}

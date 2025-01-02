namespace Solid.SRP.Demo01.Resolve;

public class OrderService : IOrderService
{
    public void AddToCart(string productName)
    {
           Console.WriteLine($"Added Product : {productName} To Cart. ");
    }

    public void CommitCart()
    {
         Console.WriteLine("Commit Cart");
    }

    public void RemoveFromCart(string productName)
    {
        Console.WriteLine($"Removed Product : {productName} From Cart. ");
    }
}

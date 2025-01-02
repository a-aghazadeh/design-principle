namespace Solid.SRP.Demo01.Resolve;

public interface IOrderService
{
     public void CommitCart();
    public void AddToCart(string productName);
    public void RemoveFromCart(string productName);
}

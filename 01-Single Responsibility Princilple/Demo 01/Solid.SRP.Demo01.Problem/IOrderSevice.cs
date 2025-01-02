namespace Solid.SRP.Demo01.Problem;

public interface IOrderSevice
{
    public void SingupUser(string userName ,string password,string confirmPassword);
    public void SinginUser(string userName ,string password);
    public void Singout();
    public void CommitCart();
    public void AddToCart(string productName);
    public void RemoveFromCart(string productName);
    public void EmailOrderConfirmation(string text);
   
}

using Solid.SRP.Demo01.Problem;

IOrderSevice service = new OrderSevice();

service.SingupUser ("Simple user","Qwe123456%","Qwe123$");
service.SinginUser ("Simple user","Qwe123456%");

service.AddToCart ("Apple Magic Keyboard");
service.AddToCart ("Apple Magic Mouse");
service.AddToCart ("Apple Magic TrackPad");
service.RemoveFromCart ("Apple Magic TrackPad");

service.CommitCart();

service.EmailOrderConfirmation("The order has been confirmed.");

service.Singout();

Console.ReadLine();

using Solid.SRP.Demo01.Resolve;

IUserService userService = new UserService();
IEmailService emailService = new EmailService();
IOrderService orderService = new OrderService();

userService.SingupUser("Simple User","123456#","123456#");
userService.SinginUser("Simple User","123456#");

orderService.AddToCart("mobile");
orderService.AddToCart("pc");
orderService.AddToCart("labtop");
orderService.RemoveFromCart("pc");

orderService.CommitCart();
emailService.EmailOrderConfirmation("The order has been confirmed.");

userService.Singout();

Console.ReadLine();

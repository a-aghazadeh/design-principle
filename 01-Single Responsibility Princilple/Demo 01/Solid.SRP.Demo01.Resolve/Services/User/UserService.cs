namespace Solid.SRP.Demo01.Resolve;

public class UserService : IUserService
{
    public void SinginUser(string userName, string password)
    {
        Console.WriteLine($"User signed in : {userName}");
    }

    public void Singout()
    {
         Console.WriteLine($"User Singout");
    }

    public void SingupUser(string userName, string password, string confirmPassword)
    {
        Console.WriteLine($"User signed up : {userName}");
    }
}

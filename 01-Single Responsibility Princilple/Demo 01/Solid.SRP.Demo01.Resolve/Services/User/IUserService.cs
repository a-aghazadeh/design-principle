namespace Solid.SRP.Demo01.Resolve;

public interface IUserService
{
    public void SingupUser(string userName ,string password,string confirmPassword);
    public void SinginUser(string userName ,string password);
    public void Singout();
}

namespace Solid.ISP.Demo01.Problem;

public class HPLaserJetP4015 : IDevice
{
    public void Fax(string content)
    {
         throw new NotImplementedException("This device cannot do this opration.");
    }

    public void PhotoCopy(string content)
    {
         throw new NotImplementedException("This device cannot do this opration.");
    }

    public void Print(string content)
    {
        Console.WriteLine($"{GetType().Name} Print has been completed.");
    }

    public void Scan(string content)
    {
         throw new NotImplementedException("This device cannot do this opration.");
    }
}

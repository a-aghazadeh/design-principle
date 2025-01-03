namespace Solid.ISP.Demo01.Problem;

public class HPScanJetG4050 : IDevice
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
        throw new NotImplementedException("This device cannot do this opration.");
    }

    public void Scan(string content)
    {
        Console.WriteLine($"{GetType().Name} Scan has been completed.");
    }
}

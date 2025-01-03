namespace Solid.ISP.Demo01.Resolve;

public class CanonScanLide30 : IFullDevice
{
    public void Fax(string content)
    {
        Console.WriteLine($"{GetType().Name} Fax has been completed.");
    }

    public void PhotoCopy(string content)
    {
        Console.WriteLine($"{GetType().Name} PhotoCopy has been completed.");
    }

    public void Print(string content)
    {
        Console.WriteLine($"{GetType().Name} Print has been completed.");
    }

    public void Scan(string content)
    {
        Console.WriteLine($"{GetType().Name} Scan has been completed.");
    }
}

namespace Solid.ISP.Demo01.Problem;

public class CanonScanLide30 : IDevice
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

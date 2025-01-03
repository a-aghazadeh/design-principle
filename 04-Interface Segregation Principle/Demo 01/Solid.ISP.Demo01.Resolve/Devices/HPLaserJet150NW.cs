namespace Solid.ISP.Demo01.Resolve;

public class HPLaserJet150NW : IScanDevice
{
    public void Scan(string content)
    {
        Console.WriteLine($"{GetType().Name} Scan has been completed.");
    }
}

namespace Solid.ISP.Demo01.Resolve;

public class HPScanJetG4050 : IScanDevice
{
    public void Scan(string content)
    {
        Console.WriteLine($"{GetType().Name} Scan has been completed.");
    }
}

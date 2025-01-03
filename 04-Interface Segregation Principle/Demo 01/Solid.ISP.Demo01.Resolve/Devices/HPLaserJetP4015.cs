namespace Solid.ISP.Demo01.Resolve;

public class HPLaserJetP4015 : IPrintDevice
{
    public void Print(string content)
    {
         Console.WriteLine($"{GetType().Name} Print has been completed.");
    }
}

namespace Solid.DI.Demo01.Resolve;

public class Presentation : IPresentation
{
    private readonly IBusiness _business;
    public Presentation(IBusiness business)
    {
        _business = business;
    }
    public void Button_Clicked(object sender, EventArgs e)
    {
        Console.WriteLine("Presentation: Button Clicked");
        object invoice = "some invoce";
        _business.CreateInvoice(invoice);
    }
}

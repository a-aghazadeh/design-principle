namespace Solid.DI.Demo01.Problem;

public class Presentation
{

    public void Button_Clicked(object sender, EventArgs e)
    {
        Console.WriteLine("Presentation: Button Clicked");
        object invoice = "some invoce";
        Business business = new Business();
        business.CreateInvoice(invoice);
    }
}

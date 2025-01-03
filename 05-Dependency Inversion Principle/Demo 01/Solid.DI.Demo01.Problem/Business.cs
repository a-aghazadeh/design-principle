namespace Solid.DI.Demo01.Problem;

public class Business
{
    public void CreateInvoice(object invoice)
    {
        Console.WriteLine("Business: Create Invoice");
        DataAccess dataAccess = new DataAccess();
        dataAccess.InsertInvoice(invoice);
    }
}

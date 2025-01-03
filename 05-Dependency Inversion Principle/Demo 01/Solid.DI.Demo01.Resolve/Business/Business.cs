namespace Solid.DI.Demo01.Resolve;

public class Business : IBusiness
{
    private readonly IDataAccess _dataAccess;
    public Business(IDataAccess dataAccess)
    {
        _dataAccess = dataAccess;
    }
    public void CreateInvoice(object invoice)
    {
        Console.WriteLine("Business: Create Invoice");
        _dataAccess.InsertInvoice(invoice);
    }

}

namespace Solid.DI.Demo01.Resolve;

public class DataAccess : IDataAccess
{
    public void InsertInvoice(object invoice)
    {
        Console.WriteLine("Data Access: Insert Invoice");
        // Fake insert into database
    }
}

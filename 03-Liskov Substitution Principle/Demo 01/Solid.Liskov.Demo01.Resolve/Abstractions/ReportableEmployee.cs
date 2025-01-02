namespace Solid.Liskov.Demo01.Resolve;

public abstract class ReportableEmployee : Employee
{
    protected ReportableEmployee(int employeeId, string employeeName) : base(employeeId, employeeName)
    {
    }
    public abstract string ReportTo();

}

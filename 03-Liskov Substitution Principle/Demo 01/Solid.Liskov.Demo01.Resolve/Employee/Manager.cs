namespace Solid.Liskov.Demo01.Resolve;

public class Manager : ReportableEmployee
{
    public Manager(int employeeId, string employeeName) : base(employeeId, employeeName)
    {
    }

    public override double CalculateBonus()
    {
        var employeeBonus = CalculateSalary() * 0.5;
        return employeeBonus;
    }

    public override double CalculateSalary()
    {
        var salary  = 50_000_000;
        return salary;
    }

    public override string ReportTo()
    {
       return "CEO";
    }
}

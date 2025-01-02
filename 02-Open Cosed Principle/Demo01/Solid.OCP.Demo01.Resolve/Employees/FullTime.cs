using Solid.OCP.Demo01.Resolve.Abstractions;
namespace Solid.OCP.Demo01.Resolve;

public class FullTime: Employee
{
    public FullTime(int employeeId, string employeeName) : base(employeeId, employeeName)
    {

    }
    public override void CalculateBonus(double salary)
    {
        var employeeBonus = salary * 0.5;
        Console.WriteLine($"Bonus for {EmployeeName}  is : {employeeBonus} ");
    }
}

namespace Solid.Liskov.Demo01.Problem;

public abstract class Employee
{
    public Employee(int employeeId,string employeeName){
        EmployeeId = employeeId;
        EmployeeName = employeeName;
    }
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; }

    public abstract double CalculateSalary();
    public abstract double CalculateBonus();
    public abstract string ReportTo();
}

namespace Solid.OCP.Demo01.Resolve.Abstractions;

public abstract class Employee
{
    public Employee(int id, string name)
    {
        EmployeeId = id;
        EmployeeName = name;
    }
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; }

    public abstract void CalculateBonus(double salary);
}

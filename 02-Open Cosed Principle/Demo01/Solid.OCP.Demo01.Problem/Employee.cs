namespace Solid.OCP.Demo01.Problem;

public class Employee
{
    public Employee(int employeeId, string employeeName, EnumContracts contracType)
    {
        EmployeeId = employeeId;
        EmployeeName = employeeName;
        EnumContracts = contracType;
    }
    public int EmployeeId { get; set;}  
    public string EmployeeName { get; set;}
    public EnumContracts EnumContracts{ get; set;}

    public void CalculateBonus(double salary)
    {
        double employeeBonus = 0;

        switch (EnumContracts)
        {
             case EnumContracts.FullTime:
                 employeeBonus = salary * 0.5;
                 break;

            case EnumContracts.FixedTerm:
                 employeeBonus = salary * 0.35;
                 break;
               
             case EnumContracts.PartTime:
                employeeBonus = salary * 0.2;
                 break;
        }
        Console.WriteLine($"Bonus for : {EmployeeName} is {employeeBonus}");
    }
}

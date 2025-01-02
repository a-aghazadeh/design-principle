﻿
using Solid.OCP.Demo01.Resolve.Abstractions;
namespace Solid.OCP.Demo01.Resolve.Employees;

internal class FixedTime : Employee
{
    public FixedTime(int employeeId, string employeeName) : base(employeeId, employeeName)
    {

    }
    public override void CalculateBonus(double salary)
    {
        var employeeBonus = salary * 0.35;
        Console.WriteLine($"Bonus for {EmployeeName}  is : {employeeBonus} ");
    }
}

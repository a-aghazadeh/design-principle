﻿namespace Solid.Liskov.Demo01.Resolve;

public class CEO : Employee
{
    public CEO(int employeeId, string employeeName) : base(employeeId, employeeName)
    {
    }

    public override double CalculateBonus()
    {
        var employeeBonus = CalculateSalary() * 1;
        return employeeBonus;
    }

    public override double CalculateSalary()
    {
        var salary = 100_000_0000;
        return salary;
    }
}
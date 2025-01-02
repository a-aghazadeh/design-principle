﻿namespace Solid.Liskov.Demo01.Resolve;

public class Developer : ReportableEmployee
{
    public Developer(int employeeId, string employeeName) : base(employeeId, employeeName)
    {
    }

    public override double CalculateBonus()
    {
        return CalculateSalary() * 0.2;
    }

    public override double CalculateSalary()
    {
        var salary = 10_000_0000;
        return salary;
    }

    public override string ReportTo()
    {
        return "Manager";
    }
}
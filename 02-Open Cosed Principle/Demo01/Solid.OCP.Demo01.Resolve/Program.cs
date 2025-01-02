using Solid.OCP.Demo01.Resolve;
using Solid.OCP.Demo01.Resolve.Abstractions;
using Solid.OCP.Demo01.Resolve.Employees;


Employee emp1 = new FixedTime(1,"Ramin");
Employee emp2 = new PartTime(2,"Ali");
Employee emp3 = new FullTime(3,"Majid");

emp1.CalculateBonus(17_000_000);
emp2.CalculateBonus(15_000);
emp3.CalculateBonus(20_000_000);

Console.ReadLine();
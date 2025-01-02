
using Solid.Liskov.Demo01.Resolve;

//Developer 
// Employee ahad= new Developer(1,"ahad");
// Employee ali= new Developer(2,"ali");

ReportableEmployee ahad= new Developer(1,"ahad");
ReportableEmployee ali= new Developer(2,"ali");

//manager 
// Employee hamid = new Manager(3,"hamid");
ReportableEmployee hamid = new Manager(3,"hamid");

// CEO
Employee hani = new CEO(4,"hani");
// ReportableEmployee hani = new Manager(3,"hani");


Console.WriteLine($"Name : {ahad.EmployeeName}");
Console.WriteLine($"Role : {ahad.GetType().Name}");
Console.WriteLine($"Salary : {ahad.CalculateSalary()}");
Console.WriteLine($"Bonus : {ahad.CalculateBonus()}");
Console.WriteLine($"ReportTo : {ahad.ReportTo()}");
Console.WriteLine();

Console.WriteLine($"Name : {ali.EmployeeName}");
Console.WriteLine($"Role : {ali.GetType().Name}");
Console.WriteLine($"Salary : {ali.CalculateSalary()}");
Console.WriteLine($"Bonus : {ali.CalculateBonus()}");
Console.WriteLine($"ReportTo : {ali.ReportTo()}");
Console.WriteLine();

Console.WriteLine($"Name : {hamid.EmployeeName}");
Console.WriteLine($"Role : {hamid.GetType().Name}");
Console.WriteLine($"Salary : {hamid.CalculateSalary()}");
Console.WriteLine($"Bonus : {hamid.CalculateBonus()}");
Console.WriteLine($"ReportTo : {hamid.ReportTo()}");
Console.WriteLine();


Console.WriteLine($"Name : {hani.EmployeeName}");
Console.WriteLine($"Role : {hani.GetType().Name}");
Console.WriteLine($"Salary : {hani.CalculateSalary()}");
Console.WriteLine($"Bonus : {hani.CalculateBonus()}");
// Console.WriteLine($"ReportTo : {hani.ReportTo()}");  ok
Console.WriteLine();

Console.ReadLine();









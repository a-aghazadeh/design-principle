using Solid.OCP.Demo01.Problem;

Employee employee1= new Employee(1,"employee1",EnumContracts.PartTime);
Employee employee2= new Employee(2,"employee2",EnumContracts.FixedTerm);
Employee employee3= new Employee(3,"employee3",EnumContracts.FullTime);

employee1.CalculateBonus(5_000_000);
employee2.CalculateBonus(12_000_000);
employee3.CalculateBonus(15_000_000);

Console.ReadLine();
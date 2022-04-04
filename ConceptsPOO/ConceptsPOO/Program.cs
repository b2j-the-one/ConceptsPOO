

using ConceptsPOO;

Console.WriteLine("Les concepts de la POO");
Console.WriteLine("======================");

//try
//{
//    Console.WriteLine(new Date(2024, 2, 29));
//    Console.WriteLine(new Date(1974, 9, 23));
//    Console.WriteLine(new Date(1985, 11, 31));
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

Employee employee1 = new SalaryEmployee()
{
    Id = 100,
    FirstName = "Ashta",
    LastName = "Austalie",
    BirthDate = new Date(1992, 5, 23),
    HiringDate = new Date(2021, 8, 13),
    IsActive = true,
    Salary = 1639.55M
};
//Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 2020,
    FirstName = "Vianney",
    LastName = "Ngomo-A-Tombet",
    BirthDate = new Date(1990, 10, 7),
    HiringDate = new Date(2022, 2, 5),
    IsActive = true,
    Sales = 3085.08M,
    CommissionPercentage = 0.03F
};
//Console.WriteLine(employee2);

Employee employee3 = new HourlyEmployee()
{
    Id = 2020,
    FirstName = "Gloire",
    LastName = "Nsoko",
    BirthDate = new Date(1999, 5, 15),
    HiringDate = new Date(2022, 3, 1),
    IsActive = true,
    HourValue = 15M,
    Hours = 160.23F
};
//Console.WriteLine(employee3);

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 2020,
    FirstName = "Borgeah",
    LastName = "Matongo",
    BirthDate = new Date(1985, 2, 22),
    HiringDate = new Date(2022, 1, 3),
    IsActive = true,
    Base = 25M,
    Sales = 974.22M,
    CommissionPercentage = 0.015F
};
//Console.WriteLine(employee4);

ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4
};

//employees.Add(employee1);
//employees.Add(employee2);
//employees.Add(employee3);
//employees.Add(employee4);

decimal payroll = 0;
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}
Console.WriteLine("                               ===================");
Console.WriteLine($"TOTAL                          {$"{payroll:C2}", 18}");

Invoice invoice1 = new Invoice()
{
    Description = "iPhone 13",
    Id = 1,
    Price = 1539.26M,
    Quantity = 6
};

Invoice invoice2 = new Invoice()
{
    Description = "Dell XPS",
    Id = 2,
    Price = 1814.99M,
    Quantity = 2
};
Console.WriteLine(invoice1);
Console.WriteLine(invoice2);

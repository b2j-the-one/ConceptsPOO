

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
Console.WriteLine(employee1);

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

Console.WriteLine(employee2);

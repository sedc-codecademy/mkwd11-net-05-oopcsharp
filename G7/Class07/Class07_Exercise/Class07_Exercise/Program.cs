using Models;

namespace Class07_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, to our company!");

            SalesPerson salesPerson1 = new SalesPerson("Sales", "One");
            SalesPerson salesPerson2 = new SalesPerson("Sales", "Two");

            Manager manager = new Manager("Manager", "Manager", 1500);

            salesPerson1.AddSuccessRevenue(300);
            salesPerson2.AddSuccessRevenue(500);

            salesPerson2.AddSuccessRevenue(300);
            salesPerson1.AddSuccessRevenue(2000);

            manager.AddBonus(450);

            Console.WriteLine(salesPerson1.GetInfo());
            Console.WriteLine(salesPerson2.GetInfo());
            Console.WriteLine(manager.GetInfo());

            Employee otherEmployee = new Employee("Risto", "Panchevski", RoleEnum.Other, 300);

            Console.WriteLine(otherEmployee.GetInfo());
        }
    }
}
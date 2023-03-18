using EmployeeApp.Domain.Enums;
using EmployeeApp.Domain.Models;

Employee employee = new Employee("John", "Johnsky", Role.Other, 600);
employee.PrintInfo();
double employeeSalary = employee.GetSalary();
Console.WriteLine(employeeSalary);

Manager manager = new Manager("Bob", "Bobsky", Role.Manager, 1000);
manager.PrintInfo(); //inherited from Employee
manager.AddBonus(100);
double managerSalary = manager.GetSalary();
Console.WriteLine(managerSalary);

SalesPerson salesPerson = new SalesPerson("Kate", "Katesky", 500);
salesPerson.PrintInfo();
salesPerson.AddSuccessRevenue(2000);
Console.WriteLine(salesPerson.GetSalary());
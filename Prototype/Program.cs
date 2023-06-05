// See https://aka.ms/new-console-template for more information
using Prototype;

Console.Title = "Prototype";

var manager = new Manager("Cindy");
var managerClone = manager.Clone() as Manager;
Console.WriteLine($"Manager was cloned: {managerClone.Name}");

var employee = new Employee("Kevin", managerClone);
var employeeClone = (Employee)employee.Clone(true);
Console.WriteLine($"Employee was cloned: {employeeClone.Name}, with manager {employeeClone.Manager.Name}");

managerClone.Name = "Douglas";
Console.WriteLine($"Employee was cloned: {employeeClone.Name}, with manager {employeeClone.Manager.Name}");


Console.ReadKey();

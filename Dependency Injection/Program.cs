using Dependency_Injection.EmployeeBLF;
using Dependency_Injection.EmployeeClass;
using Dependency_Injection.EmployeeDALF;
using System;
using System.Collections.Generic;

namespace Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeBL employeeBL = new EmployeeBL(new EmployeeDAL());
            List<Employee> ListEmployee = employeeBL.GetAllEmployees();
            foreach (Employee emp in ListEmployee)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.ID, emp.Name, emp.Department);
            }
            Console.ReadKey();
        }
    }
}

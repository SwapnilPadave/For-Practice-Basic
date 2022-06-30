using Dependency_Injection.EmployeeClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection.EmployeeDALF
{
    public interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployee();
    }
    public class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee> SelectAllEmployee()
        {
            List<Employee> ListEmployees = new List<Employee>();

            ListEmployees.Add(new Employee() { ID = 1, Name = "Swapnil", Department = "IT" });
            ListEmployees.Add(new Employee() { ID = 2, Name = "Vijay", Department = "HR" });
            ListEmployees.Add(new Employee() { ID = 3, Name = "Nilesh", Department = "Payroll" });
            return ListEmployees;
        }
    }
}

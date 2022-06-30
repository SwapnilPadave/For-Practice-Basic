using Dependency_Injection.EmployeeClass;
using Dependency_Injection.EmployeeDALF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection.EmployeeBLF
{
    public class EmployeeBL
    {
        public IEmployeeDAL employeeDAL;

        public EmployeeBL(IEmployeeDAL employeeDAL)
        {
            this.employeeDAL = employeeDAL;
        }
        public List<Employee> GetAllEmployees()
        {
            employeeDAL = new EmployeeDAL();
            return employeeDAL.SelectAllEmployee();
        }
    }
}

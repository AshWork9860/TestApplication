using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.DTO.Model;
using TestApplication.Repositories.Interfaces;

namespace TestApplication.Repositories.Implementation
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _employees;

        public EmployeeRepository()
        {
            _employees = new List<Employee>();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employees;
        }

        public IEnumerable<Employee> GetAllEmployeesByType(int employeeType)
        {
            return _employees.Where(x=>x.EmployeeTypeID==employeeType);
        }


        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }
    }
}

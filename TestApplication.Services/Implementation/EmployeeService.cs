using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.DTO.Model;
using TestApplication.Repositories.Interfaces;
using TestApplication.Services.Interfaces;

namespace TestApplication.Services.Implementation
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAllEmployees();
        }

        public IEnumerable<Employee> GetAllEmployeesByType(int employeeType)
        {
            return _employeeRepository.GetAllEmployeesByType(employeeType);
        }
        
        public void AddEmployee(Employee employee)
        {
            _employeeRepository.AddEmployee(employee);
        }
    }
}

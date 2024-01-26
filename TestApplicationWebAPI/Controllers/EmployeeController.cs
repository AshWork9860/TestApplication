using Microsoft.AspNetCore.Mvc;
using TestApplication.DTO.Model;
using TestApplication.Services.Interfaces;

namespace TestApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var employees = _employeeService.GetAllEmployees();
            return Ok(employees);
        }


        /// <summary>
        /// this method can help to get Employee/Superwiser and Manager separetely by its employeeType(Manager/Superwiser/Employee)
        /// </summary>
        /// <param name="employeeType"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllEmployeesByType(int employeeType)
        {
            var employees = _employeeService.GetAllEmployees();
            return Ok(employees);
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            _employeeService.AddEmployee(employee);
            return Ok();
        }
    }
}

using NUnit.Framework;
using Moq;
using System.Collections.Generic;
using System.Linq;
using TestApplication.Repositories.Interfaces;
using TestApplication.Services.Implementation;
using TestApplication.DTO.Model;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestApplications.UnitTests
{
    [TestClass]
    public class EmployeeServiceTests
    {
        private Mock<IEmployeeRepository> _mockRepository;
        private EmployeeService _employeeService;

        [SetUp]
        public void Setup()
        {
            _mockRepository = new Mock<IEmployeeRepository>();
            _employeeService = new EmployeeService(_mockRepository.Object);
        }

        [Test]
        public void GetAllEmployees_Returns_All_Employees()
        {
            // Arrange
            var expectedEmployees = new List<Employee>
            {
                new Employee { EmployeeID = 1, FirstName = "Ashher", LastName = "Ali" },
                new Employee { EmployeeID = 2, FirstName = "Lionel", LastName = "Messi" }
            };

            _mockRepository.Setup(repo => repo.GetAllEmployees()).Returns(expectedEmployees);

            // Act
            var result = _employeeService.GetAllEmployees();

            // Assert
            Assert.AreEqual(expectedEmployees.Count, result.Count());
            Assert.AreEqual(expectedEmployees.First().FirstName, result.First().FirstName);
            Assert.AreEqual(expectedEmployees.Last().LastName, result.Last().LastName);
        }

        [Test]
        public void AddEmployee_Adds_New_Employee()
        {
            // Arrange
            var employeeToAdd = new Employee { FirstName = "Ashher", LastName = "Ali" };

            _mockRepository.Setup(repo => repo.AddEmployee(employeeToAdd));

            // Act
            _employeeService.AddEmployee(employeeToAdd);

            // Assert
            _mockRepository.Verify(repo => repo.AddEmployee(employeeToAdd), Times.Once);
        }
    }
}
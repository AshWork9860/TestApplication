﻿namespace TestApplication.DTO.Model
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public decimal PayPerHour { get; set; }
        public decimal AnnualSalary { get; set; }
        public decimal MaxExpenseAmount { get; set; }
        public int EmployeeTypeID { get; set; }
        public EmployeeType EmployeeType { get; set; }
    }
}

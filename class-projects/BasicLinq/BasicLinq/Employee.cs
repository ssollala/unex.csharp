using System.Collections.Generic;

namespace BasicLinq
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal AnnualSalary { get; set; }

        public static List<Employee> GetAllEmployeeData()
        {
            List<Employee> listEmployees = new List<Employee>
           {
               new Employee
               {
                   EmployeeID = 101,
                   FirstName = "Harriet",
                   LastName="Jones",
                   AnnualSalary = 123000.00M
               },
               new Employee
               {
                   EmployeeID = 102,
                   FirstName = "Roy",
                   LastName="Rodgers",
                   AnnualSalary = 40000.00M
               },
               new Employee
               {
                   EmployeeID = 103,
                   FirstName = "Carol",
                   LastName="Smith",
                   AnnualSalary = 60000.00M
               },
               new Employee
               {
                   EmployeeID = 104,
                   FirstName = "Bruin",
                   LastName="Joes",
                   AnnualSalary = 100000.00M
               }
           };

            return listEmployees;
        }

    }
}

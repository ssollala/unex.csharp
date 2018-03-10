using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = Employee.GetAllEmployeeData();

            // var result
            IEnumerable<int> result = employees.Select(emp => emp.EmployeeID);

            foreach(int empID in result)
            {
                Console.WriteLine($"EmpID: {empID}");
            }

            var queryresult = employees.Select(emp => new
            {
                FirstName = emp.FirstName,
                LastName = emp.LastName
            });

            foreach (var item in queryresult)
            {
                Console.WriteLine($"First Nmae: {item.FirstName}, Last Name: {item.LastName}");
            }

            var queryresult2 = employees.Select(emp => new
            {
                FullName = emp.FirstName + " " + emp.LastName,
                MonthlySalary = emp.AnnualSalary / 12M
            });

            foreach(var item in queryresult2)
            {
                Console.WriteLine("Name = {0}, Monthly Salary = {1:C}", item.FullName, item.MonthlySalary);
            }

            var queryresult3 = employees.Where(emp => emp.AnnualSalary > 50000).Select(emp => new
            {
                FullName = emp.FirstName + " " + emp.LastName,
                MonthlySalary = emp.AnnualSalary / 12M,
                Bonus = emp.AnnualSalary * 0.01M
            });

            foreach (var item in queryresult3)
            {
                Console.WriteLine("Name = {0}, Monthly Salary = {1:C}, Bonus = {2:C}",
                    item.FullName, item.MonthlySalary, item.Bonus);
            }

            Console.WriteLine("\nPress <Enter> to quit...");
            Console.ReadKey();

        }
    }
}

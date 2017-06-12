using System;
using System.Linq;
using BesTests.Pages;
using NUnit.Framework;

namespace BesTests.Tests
{
    [TestFixture]
    public class GetObjectEmployeeDataTest : BesTestsBase
    {
        [Test]
        public void PrintNamesOfAllEmployees()
        {
            //loop through all employees and write line all names
            var employeesPage = LoginAndGoToHome().GoToEmployeesPage();
            var employees = employeesPage.Employees.Where(a => a.Branch == "All");
            foreach (var emoloyeeRow in employees)
            {
                Console.WriteLine(emoloyeeRow.Name);
            }
        }

        [Test]
        public void EditEmployee()
        {
            //loop through all employees and writeline all names
            var employeesPage = LoginAndGoToHome().GoToEmployeesPage();
            var employee = employeesPage.Employees.First(a => a.Name == "Transfer Naomi");
            employee.Edit();
        }

        [Test]
        public void SelectMessage()
        {
            //loop through all employees and writeline all names
            var employeesPage = LoginAndGoToHome().GoToEmployeesPage();
            var employees = employeesPage.Employees.Where(a => a.Name.Contains("Naomi"));
            foreach (var emoloyeeRow in employees)
            {
                emoloyeeRow.CheckMessage();
            }
        }

        [Test]
        public void CheckRolesFilter()
        {
            var employeesPage = LoginAndGoToHome().GoToEmployeesPage();
            var realTeachersCount = employeesPage.Employees.Count(a => a.Roles.Contains(EmployeeRole.Teacher));
            employeesPage.FilterByRole(EmployeeRole.Teacher);
            var actualCountAfterFilter = employeesPage.Employees.Count;
            Assert.AreEqual(realTeachersCount,actualCountAfterFilter);
        }
    }
}

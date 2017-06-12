using OpenQA.Selenium;
using PageObject3.Pages.EmploeesPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace PageObject3.Pages.EmploeesPage
{
    public class EmployeesTablePage : BasePage
    {

        public EmployeesTablePage(IWebDriver driver) : base(driver, By.CssSelector(".utilities-employees-main"))
        {
        }

        private SelectElement RolesDropDownList => new SelectElement(WaitForElement(
            By.CssSelector(".utilities-employees-filter-select.utilities-employees-role-filter-select")));

        public List<EmoloyeeRow> Employees
        {
            get
            {
                var rowsElements = driver.FindElements(By.CssSelector(".utilities-employees-table-tr"));
                List<EmoloyeeRow> employees = new List<EmoloyeeRow>();
                foreach (var row in rowsElements)
                {
                    EmoloyeeRow e = new EmoloyeeRow(row, driver);
                    employees.Add(e);
                    //Console.WriteLine(employees[1].Name);
                }
                return employees;
            }
        }

        public List<EmoloyeeRow> EmployeesGetEmployeeRow => driver
            .FindElements(By.CssSelector("utilities-employees-table-tr"))
            .Select(a => new EmoloyeeRow(a, driver)).ToList();

        public AddEditEmployeePage ClickAdd()
        {
            WaitForElement(By.CssSelector("button.utilities-employees-add-btn")).Click();
            return new AddEditEmployeePage(driver);
        }

        public EmployeesTablePage FilterByRole(EmployeeRole employeeRole)
        {
            var oldCount = EmployeesCount;
            int valueToSelect = (int) employeeRole;
            RolesDropDownList.SelectByValue(valueToSelect.ToString());
            WaitUntil(o => EmployeesCount != oldCount, timeOutInSec: 3, throwExceptionIfTimeoutReached: false);
            return this;
        }

        public void SelectAllMessages()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@class='utilities-employees-msg-chk-all']")).Click();
        }

        public string EmployeesCount => WaitForElement(By.Id("utilities-employees-count-span")).Text;
    }
}
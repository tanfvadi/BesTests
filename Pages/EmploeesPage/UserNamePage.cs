using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium;

namespace BesTests.Pages.EmploeesPage
{
    public class UserNamePage
    {
        private IWebDriver driver;
        public string names;
        public IWebElement rowElement;

        public UserNamePage(IWebDriver driver)
        {
            //this.rowElement = rowElement;
            this.driver = driver;
        }

        public void GetNamesFromEmployeesPage()
        {
            Thread.Sleep(1000);
            IList<IWebElement> names = driver.FindElements(By.CssSelector("td.utilities-employees-table-employee-name"));
            foreach (IWebElement element in names)
            if (element.Text.Contains("Diana"))
            Console.WriteLine("{0}", element.Text);
        }
    }
}

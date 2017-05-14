using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PageObject3.Pages
{
    public class UserNamePage
    {
        private IWebDriver driver;
        public string Name;
        public IWebElement rowElement;

        public UserNamePage(IWebDriver driver)
        {
            //this.rowElement = rowElement;
            this.driver = driver;
        }

        public void GetNamesFromEmployeesPage()
        {
            Thread.Sleep(1000);
            foreach (IWebElement element in driver.FindElements(By.CssSelector("td.utilities-employees-table-employee-name")))
                if (element.Text.Contains("Diana"))
            Console.WriteLine("{0}", element.Text);
        }
    }
}

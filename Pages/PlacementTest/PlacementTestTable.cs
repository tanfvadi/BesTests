using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PageObject3.Pages.PlacementTest
{
    public class PlacementTestTable
    {
        protected IWebDriver driver;
        public void CheckPTTable()
        {
            Thread.Sleep(1000);
            foreach (IWebElement element in driver.FindElements(By.CssSelector("tr.allocated-tests-table")))
                    Console.WriteLine(element.Text + Environment.NewLine + "-------------------------------------------");
        }
    }
}

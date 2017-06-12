using System;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;

namespace BesTests.Pages.PlacementTests
{
    public class PlacementTestPage : BasePage
    {

        public PlacementTestPage(IWebDriver driver)
            : base(driver, By.Id("btnPlacementTest"), 10)
        {
        }

        public PlacementTestPage ClickOnPTButton()
        {
            WaitForElement(By.Id("btnPlacementTest"), 10).Click();
            return new PlacementTestPage(driver);
        }

        public PlacementTestPage ClickOnAllocate()
        {
            WaitForElement(By.Id("btnAllocatePlacementTest"), 10).Click();
            return this;
        }

        public PlacementTestPage CheckIfIssueDateIsRed()
        {
            var red = (WaitForElement(By.XPath("//td[@class='td-issue-date pl-not-registered']")));
            if (red.GetAttribute("title") == "Customer Not Registered")
                 Console.WriteLine("The user not registred yet");  
            return this;
        }

        public PlacementTestPage CheckIfBEInfoExist()
        {
            Thread.Sleep(1000);
            WaitForElement(By.Id("btnCancelPlacementTestAllocation"), 10).Click();
            var beinfo = (WaitForElement(By.XPath("//input[@class='btn button-115 first alert' and @value ='BE Info']")));
            if (beinfo.GetAttribute("value") == "BE Info")
                Console.WriteLine("BE Info button is appear");
            return this;
        }

        public void CheckIfAllocateButtonIsEnabled()
        {
            IWebElement enabled = WaitForElement(By.Id("btnAllocatePlacementTest"), 10);
            if (enabled.Enabled)
            {
                Console.WriteLine("The button is enabled");
            }
            else
            {
                Console.WriteLine("The button is disabled");
            }

        }

        public void CheckIfPTTableIsEmpty()
        {
            foreach (var row in driver.FindElements(By.CssSelector("tr.allocated-tests-table")))
            {
                if (row.FindElements(By.CssSelector("td")).Any(r => r.Text != "-"))
                {                  
                    Console.WriteLine("The PT table isn't empty!");
                }
            }

        }
    }
}

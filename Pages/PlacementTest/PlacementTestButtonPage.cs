using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PageObject3.Pages.PlacementTest
{
    public class PlacementTestButtonPage:BasePage
    {

        public PlacementTestButtonPage(IWebDriver driver)
            : base(driver, By.Id("btnPlacementTest"), 10)
        {
        }

        public PlacementTestButtonPage ClickOnPTButton()
        {
            WaitForElement(By.Id("btnPlacementTest"), 10).Click();
            return new PlacementTestButtonPage(driver);
        }

        public void CheckIfAllocateButtonIsEnable()
        {
            WaitForElement(By.Id("btnPlacementTest"), 10).Click();
            IWebElement enable= WaitForElement(By.Id("btnAllocatePlacementTest"), 10);
            if (enable.Enabled)
            {
                Console.WriteLine("The button is enabled");
            }
            else
            {
                Console.WriteLine("The button is disabled");
            }

        }

    }
}

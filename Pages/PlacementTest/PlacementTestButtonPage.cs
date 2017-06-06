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

        public PlacementTestButtonPage ClickOnAllocate()
        {
            WaitForElement(By.Id("btnAllocatePlacementTest"), 10).Click();
            return new PlacementTestButtonPage(driver);
        }


        public void CheckIfAllocateButtonIsEnabled()
        {
            IWebElement enabled= WaitForElement(By.Id("btnAllocatePlacementTest"), 10);
            if (enabled.Enabled)
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

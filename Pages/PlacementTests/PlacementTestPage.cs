﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;

namespace PageObject3.Pages.PlacementTest
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

        public void CheckPTTable()
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
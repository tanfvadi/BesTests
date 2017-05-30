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

    }
}

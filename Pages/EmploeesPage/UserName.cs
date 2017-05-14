using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject3.Pages.EmploeesPage
{
    public class UserName
    {
        private IWebDriver driver;
        public string Name;
        public IWebElement rowElement;

        public UserName(IWebElement rowElement, IWebDriver driver)
        {
            this.rowElement = rowElement;
            this.driver = driver;
        }
    }
}

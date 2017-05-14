using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject3.Pages.EmploeesPage
{
    public class UserMessage
    {
        private IWebDriver driver;
        public IWebElement rowElement;

        public UserMessage(IWebElement rowElement, IWebDriver driver)
        {
            this.rowElement = rowElement;
            this.driver = driver;
        }
    }
}

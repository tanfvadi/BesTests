using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PageObject3.Pages
{
    public class UserMessagePage
    {
        public IWebDriver driver;
        public bool Message;
        public IWebElement rowElement;
        private IWebElement rowWebElement;

        //public UserMessagePage(IWebDriver driver) : base(driver, By.XPath("//div[@class='utilities-employees-msg-header'"), 10)
        //{
        //}

        //public UserMessagePage(IWebElement rowWebElement, IWebDriver driver)
        //{
        //    this.rowWebElement = rowWebElement;
        //    this.driver = driver;
        //}


        public UserMessagePage(IWebElement rowWebElement, IWebDriver driver)
        {
            this.rowWebElement = rowWebElement;
            this.driver = driver;
        }

        public UserMessagePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SelectAllMessages()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@class='utilities-employees-msg-chk-all']")).Click();
        }
    }
}

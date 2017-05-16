using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace PageObject3.Pages
{
    public class AddEmployeePage:BasePage
    {


        //public void RandomGenerate()
        //{
        //    throw new NotImplementedException();
        //}


        //public AddEmployeePage(IWebDriver driver)
        //{
        //    this.driver = driver;
        //}


        //public AddEmployeePage(IWebDriver driver, By pageVerifierLocator, int pageLoadedTimeout = 10) : base(driver, pageVerifierLocator, pageLoadedTimeout)
        //{
        //}

        public AddEmployeePage(IWebDriver driver) : base(driver, By.XPath("//div[@class='utilities-employees-header']"), 10)
        {

        }

        public Random random = new Random();
        public string RandomString(int length)
        {
            const string chars = "ABCDEFGH";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public AddEmployeePage FillNewEmployeeAndSave(string username = null)
        {
            username = username ?? RandomString(8);
            WaitForElement(By.CssSelector(".btn.button-59.utilities-employees-add-btn"), 10).Click();
            WaitForElement(By.XPath("//input[@class='utilities-employees-popup-first-name']"), 10).SendKeys(username);
            WaitForElement(By.XPath("//input[@class='utilities-employees-popup-last-name']"), 10).SendKeys(username);
            WaitForElement(By.XPath("//input[@class='utilities-employees-popup-input utilities-employees-popup-login-name']"), 10).SendKeys(username);
            WaitForElement(By.XPath("//input[@class='utilities-employees-popup-input utilities-employees-popup-login-password']"), 10).SendKeys("12345");
            WaitForElement(By.XPath("//input[@class='utilities-employees-popup-input utilities-employees-popup-email']"), 10).SendKeys(username + "@ecb.com");
            WaitForElement(By.XPath("//input[@class='utilities-employees-popup-input utilities-employees-popup-cellphone  digits-only']"), 10).SendKeys("037936677");
            WaitForElement(By.CssSelector(".utilities-employees-popup-info.utilities-employees-popup-info-mothertongue")).Click();
            //Thread.Sleep(1000);
            new SelectElement(WaitForElement(By.CssSelector(".utilities-employees-popup-select.utilities-employees-popup-mothertongue"))).SelectByIndex(1);
            WaitForElement(By.CssSelector(".utilities-employees-popup-roles")).Click();
            new SelectElement(WaitForElement(By.XPath(".utilities-employees-popup-roles"))).SelectByIndex(1);
            WaitForElement(By.CssSelector(".utilities-employees-popup-branches")).Click();
            new SelectElement(WaitForElement(By.XPath(".utilities-employees-popup-branches"))).SelectByIndex(1);
            WaitForElement(By.XPath("//button[@class='btn button-59 utilities-employees-save-btn']")).Click();
            return new AddEmployeePage(driver);
        }     
    }
}

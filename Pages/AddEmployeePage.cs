using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PageObject3.Pages
{
    public class AddEmployeePage:BasePage
    {
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
        public AddEmployeePage FillNewEmployeeAndSave()
        {
            WaitForElement(By.XPath("//button[@class='btn button-59 utilities-employees-add-btnt']"), 10).Click();
            WaitForElement(By.XPath("//input[@class='utilities-employees-popup-first-name']"), 10).SendKeys("Vadim");
            WaitForElement(By.XPath("//input[@class='utilities-employees-popup-last-name']"), 10).SendKeys("Test");
            WaitForElement(By.XPath("//input[@class='utilities-employees-popup-input utilities-employees-popup-login-password']"), 10).SendKeys("12345");
            WaitForElement(By.XPath("//input[@class='utilities-employees-popup-input utilities-employees-popup-email']"), 10).SendKeys("vadim@ecb.com");
            WaitForElement(By.XPath("//input[@class='utilities-employees-popup-input utilities-employees-popup-cellphone  digits-only']"), 10).SendKeys("037936677");
            new SelectElement(WaitForElement(By.XPath("//button[@class='ui-multiselect ui-widget ui-state-default ui-corner-all input-invalid' and ttle='Arabic']"))).SelectByIndex(0);
            new SelectElement(WaitForElement(By.XPath("//button[@class='ui-multiselect ui-widget ui-state-default ui-corner-all']"))).SelectByIndex(0);
            new SelectElement(WaitForElement(By.XPath("//button[@class='ui-multiselect ui-widget ui-state-default ui-corner-all input-invalid' and ttle='Select Branches']"))).SelectByIndex(0);
            WaitForElement(By.XPath("//button[@class='btn button-59 utilities-employees-save-btn']")).Click();
            return new AddEmployeePage(driver);
        }
    }
}

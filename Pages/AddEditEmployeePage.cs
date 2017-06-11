using System;
using System.Linq;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace PageObject3.Pages
{
    public class AddEditEmployeePage:BasePage
    {

        public AddEditEmployeePage(IWebDriver driver) : base(driver, By.XPath("//div[@class='utilities-employees-header']"), 10)
        {

        }

        public Random random = new Random();
        public string RandomString(int length)
        {
            const string chars = "ABCDEFGH";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public AddEditEmployeePage FillNewEmployeeAndSave(string username = null)
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
            WaitForElement(By.XPath("//label[@class='ui-corner-all ui-state-hover']")).Click();
            WaitForElement(By.XPath("//input[@class='utilities-employees-popup-first-name']"), 10).Click();

            WaitForElement(By.CssSelector(".utilities-employees-popup-info.utilities-employees-popup-info-roles")).Click();
            WaitForElement(By.XPath("//label[@class='ui-corner-all ui-state-hover']")).Click();
            WaitForElement(By.XPath("//input[@class='utilities-employees-popup-first-name']"), 10).Click();
            WaitForElement(By.CssSelector(".utilities-employees-popup-all-branches-chk")).Click();
            Thread.Sleep(1000);
            Console.WriteLine("User Name is: " + WaitForElement(By.XPath("//input[@class='utilities-employees-popup-input utilities-employees-popup-login-name']")).GetAttribute("value"));
            WaitForElement(By.XPath("//button[@class='btn button-59 utilities-employees-save-btn']")).Click();
            return new AddEditEmployeePage(driver);
        }

        public AddEditEmployeePage AddSubTeachers()
        {
            WaitForElement(By.XPath("//select[@class='utilities-employees-filter-select utilities-employees-role-filter-select']"), 10).Click();
            new SelectElement(WaitForElement(By.XPath("//select[@class='utilities-employees-filter-select utilities-employees-role-filter-select']"), 10)).SelectByIndex(12);
            WaitForElement(By.CssSelector("[data-id='122169']"), 10).Click();
            WaitForElement(By.CssSelector(".substitute-teacher-left-itm.substitute-teacher-input.ui-autocomplete-input"), 10).Click();
            WaitForElement(By.CssSelector(".substitute-teacher-left-itm.substitute-teacher-input.ui-autocomplete-input"), 10).SendKeys("va");
            WaitForElement(By.XPath("//a[contains(@id,'ui-id') and text()='Vadim Teacher']"), 10).Click();
            WaitForElement(By.XPath("//button[@class='btn button-59 utilities-employees-save-btn' and text()='Save']"), 10).Click();
            return new AddEditEmployeePage(driver);
        }

        public AddEditEmployeePage DeleteSubTeachers()
        {
            WaitForElement(By.XPath("//select[@class='utilities-employees-filter-select utilities-employees-role-filter-select']"), 10).Click();
            new SelectElement(WaitForElement(By.XPath("//select[@class='utilities-employees-filter-select utilities-employees-role-filter-select']"), 10)).SelectByIndex(12);
            WaitForElement(By.CssSelector("[data-id='122169']"), 10).Click();
            WaitForElement(By.CssSelector(".substitute-teacher-left-itm.substitute-teacher-input.ui-autocomplete-input"), 10).Click();
            WaitForElement(By.CssSelector(".substitute-teacher-left-itm.substitute-teacher-input.ui-autocomplete-input"), 10).Clear();
            WaitForElement(By.XPath("//button[@class='btn button-59 utilities-employees-save-btn']"), 10).Click();
            return new AddEditEmployeePage(driver);
        }
    }
}

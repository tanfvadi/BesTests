using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BesTests.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;
        private By PageVerifierLocator;

        public BasePage(IWebDriver driver, By pageVerifierLocator, int pageLoadedTimeout = 10)
        {
            PageVerifierLocator = pageVerifierLocator;
            this.driver = driver;
            VerifyPageLoaded(pageLoadedTimeout);
            WaitUntilElementNotVisible(By.Id("calendar-loader"), 10, null);
        }

        protected string PageName => GetType().Name;

        protected void CheckAvailibility()
        {
            IWebElement element = driver.FindElement(By.CssSelector("div[title=Meeting]"));
            ReadOnlyCollection<IWebElement> elements = driver.FindElement(By.Id("assignee")).FindElements(By.TagName("option"));
            int index = 0;
            if (index >= elements.Count)
                return;
            if (element.Displayed)
                new SelectElement(WaitForElement(By.Id("assignee"), 10)).SelectByIndex(index);
            else
                new SelectElement(WaitForElement(By.Id("assignee"), 10)).SelectByIndex(6);
        }

        protected void ClickOnAlertButton()
        {
            WaitForElement(By.Id("btnDisplayEntityAlert"), 10).Click();
        }

        protected List<T> FindElementsByCss<T>(string selector)
        {
            //Find all courses rows IWebElements
            var allIWebElements = WaitForElements(By.CssSelector(selector));
            //For each element return New CourseRow and send him(IWebElement,driver)
            List<T> elementsToReturn =
                allIWebElements.Select(a => (T)Activator.CreateInstance(typeof(T), a, driver)).ToList();
            return elementsToReturn;
        }

        protected void VerifyPageLoaded(int timeoutInSec = 10)
        {
            string messageIfFailed = "Page: " + PageName + " was not loaded!!";
            try
            {
                Wait(timeoutInSec, messageIfFailed).Until(ExpectedConditions.ElementIsVisible(PageVerifierLocator));
            }
            catch (WebDriverTimeoutException ex)
            {
                throw new NotOnExpectedPageException(ex.Message);
            }
        }

        protected IWebElement WaitForElement(By by, int timeOutInSec = 10)
        {
            string messageIfFailed = "Could not find element:" + by.ToString() + " after waiting:" + timeOutInSec + " seconds.";
            return Wait(timeOutInSec, messageIfFailed).Until(ExpectedConditions.ElementIsVisible(by));
        }

        protected ReadOnlyCollection<IWebElement> WaitForElements(By by, int timeOutInSec = 10)
        {
            string messageIfFailed = "Could not find element:" + by.ToString() + " after waiting:" + timeOutInSec + " seconds.";
            return Wait(timeOutInSec, messageIfFailed).Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(by));
        }

        protected void WaitUntil(Func<object, bool> a, string message = null, int timeOutInSec = 10,
          bool throwExceptionIfTimeoutReached = true)
        {
            var wait = new DefaultWait<object>(new object(), new SystemClock());
            if (message != null)
                wait.Message = message;
            wait.Timeout = TimeSpan.FromSeconds(timeOutInSec);
            wait.IgnoreExceptionTypes(typeof(Exception));

            try
            {
                wait.Until(a);
            }
            catch (Exception)
            {
                if (throwExceptionIfTimeoutReached)
                    throw;
            }
        }

        protected void WaitUntilElementNotVisible(By by, int timeoutInSec = 10, string messageIfFailed = null)
        {
            Wait(timeoutInSec, messageIfFailed).Until<bool>(ExpectedConditions.InvisibilityOfElementLocated(by));
        }

        protected void WaitUntilPageDisappears(int timeoutInSec = 10)
        {
            string messageIfFailed = "Page " + PageName + " was not disappeared after: " + timeoutInSec + " seconds.";
            WaitUntilElementNotVisible(PageVerifierLocator, timeoutInSec, messageIfFailed);
        }

        private WebDriverWait Wait(int timeOutInSec = 10, string messageIfFailed = null)
        {
            WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSec));
            if (messageIfFailed != null)
                webDriverWait.Message = messageIfFailed;
            return webDriverWait;
        }
    }
}

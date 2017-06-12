// Decompiled with JetBrains decompiler
// Type: PageObject3.Pages.LoginPage
// Assembly: PageObject3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0D9DC055-2B5D-4B03-9C15-724F3DFE242F
// Assembly location: C:\Users\vadim.t.ECB\Documents\Visual Studio 2015\Projects\PageObject3\PageObject3\bin\Debug\PageObject3.dll

using System;
using BesTests.Pages.Alerts;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;

namespace BesTests.Pages
{
  public class LoginPage : BasePage
  {
    private LoginPage(IWebDriver driver)
      : base(driver, By.XPath("//span[text()='Login']"), 10)
    {
    }

    public static LoginPage GoToLoginPage(IWebDriver driver)
    {
        driver.Navigate().GoToUrl("https://beweb.ecb.co.il/account/login");
       // driver.Navigate().GoToUrl("https://172.72.203.201/BESMZPL");
        return new LoginPage(driver);
    }

    public BesHomePage LoginAndGoToBES(string username, string password)
    {
            WaitForElement(By.Name("username"), 10).SendKeys("roles.manager");
            WaitForElement(By.Name("password"), 10).SendKeys("12345");
            WaitForElement(By.XPath("//span[text()='Log In']"), 10).Click();
            WaitForElement(By.XPath("//span[text()='School Management']"), 10).Click();
      new SelectElement(WaitForElement(By.Name("branchEntityID"), 10)).SelectByValue("26711");
            WaitForElement(By.CssSelector("[class='btn button-59']"), 10).Click();
      return new BesHomePage(driver);
    }

    public ForgotPasswordPage GoToForgotPasswordPage()
    {
            driver.Navigate().GoToUrl("https://beweb.ecb.co.il/account/login");
            WaitForElement(By.XPath("//span[text()='Forgot Password?']"), 10).Click();
      return new ForgotPasswordPage(driver);
    }

    public void LoginExpectingError(string username, string password)
    {
            WaitForElement(By.Name("username"), 10).SendKeys("fffff");
            WaitForElement(By.Name("password"), 10).SendKeys("12345");
            WaitForElement(By.XPath("//span[text()='Log In']"), 10).Click();
    }

    public AlertPage LoginAndGoToBES()
    {
      throw new NotImplementedException();
    }

    public string GetUsername()
    {
      return WaitForElement(By.Name("username"), 10).GetAttribute("value");
    }

    public CustomerPage RedFrame()
    {
            driver.ExecuteJavaScript("arguments[0].style.border = '3px solid red'");
      return new CustomerPage(driver);
    }
  }
}

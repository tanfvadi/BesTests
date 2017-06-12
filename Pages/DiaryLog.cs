using System;
using System.Text.RegularExpressions;
using System.Threading;
using OpenQA.Selenium;

namespace BesTests.Pages
{
  public class DiaryLog
  {
    private IWebElement rowElement;
    private IWebDriver driver;

    public CustomerPage.DiaryLogType LogType
    {
      get
      {
        return (CustomerPage.DiaryLogType) Enum.Parse(typeof (CustomerPage.DiaryLogType), Regex.Replace(rowElement.FindElement(By.CssSelector("td.type")).Text.Trim(), "\\s+", ""), true);
      }
    }

    public CustomerPage.LeadLogActionType ActionLogType
    {
      get
      {
        return (CustomerPage.LeadLogActionType) Enum.Parse(typeof (CustomerPage.LeadLogActionType), Regex.Replace(rowElement.FindElement(By.CssSelector("td.type")).Text.Trim(), "\\s+", ""), true);
      }
    }

    public DiaryLog(IWebElement rowElement, IWebDriver driver)
    {
      this.rowElement = rowElement;
      this.driver = driver;
    }

    public DiaryLog ClickOnLog()
    {
      rowElement.Click();
      Thread.Sleep(1000);
      return this;
    }

    public AlertSummary ClickToSeeAlertSummary()
    {
      ClickOnLog();
      return new AlertSummary(driver);
    }

    public SaleSummary ClickToSeeSaleSummary()
    {
      ClickOnLog();
      return new SaleSummary(driver);
    }
  }
}

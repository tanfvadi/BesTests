
using OpenQA.Selenium;
using System;
using System.Text.RegularExpressions;
using System.Threading;
using static PageObject3.Pages.CustomerPage;

namespace PageObject3.Pages
{
  public class DiaryLog
  {
    private IWebElement rowElement;
    private IWebDriver driver;

    public DiaryLogType LogType
    {
      get
      {
        return (DiaryLogType) Enum.Parse(typeof (DiaryLogType), Regex.Replace(rowElement.FindElement(By.CssSelector("td.type")).Text.Trim(), "\\s+", ""), true);
      }
    }

    public LeadLogActionType ActionLogType
    {
      get
      {
        return (LeadLogActionType) Enum.Parse(typeof (LeadLogActionType), Regex.Replace(rowElement.FindElement(By.CssSelector("td.type")).Text.Trim(), "\\s+", ""), true);
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

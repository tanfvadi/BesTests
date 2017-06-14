
using OpenQA.Selenium;

namespace BesTests.Pages.Alerts
{
  public class AlertSummary : BasePage
  {
    public string AlertMessage
    {
      get
      {
        return WaitForElement(By.ClassName("lead-entity-alert-message-alert"), 10).GetAttribute("value");
      }
    }

    public AlertSummary(IWebDriver driver)
      : base(driver, By.XPath("//div[@class='label' and text()='IsMessageSelected:']"), 10)
    {
    }
  }
}

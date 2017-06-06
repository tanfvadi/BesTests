
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using PageObject3.Pages.PlacementTest;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PageObject3.Pages
{
  public class CustomerPage : BasePage
  {
    public List<DiaryLog> AllLogs
    {
      get
      {
        return WaitForElements(By.CssSelector("tr[data-log-id][class]:not(.action)"), 10).Select<IWebElement, DiaryLog>(rowWebElement => new DiaryLog(rowWebElement, driver)).ToList<DiaryLog>();
      }
    }

    public List<DiaryLog> ActionLogs
    {
      get
      {
        return WaitForElements(By.CssSelector("tr[data-log-id].action"), 10).Select<IWebElement, DiaryLog>(rowWebElement => new DiaryLog(rowWebElement, driver)).ToList<DiaryLog>();
      }
    }

    public List<DiaryLog> SaleLogs
    {
      get
      {
        return AllLogs.Where<DiaryLog>(a => a.LogType == DiaryLogType.Sale).ToList<DiaryLog>();
      }
    }

    public List<DiaryLog> AlertLogs
    {
      get
      {
        return AllLogs.Where<DiaryLog>(a => a.ActionLogType == LeadLogActionType.MeetingSchedule).ToList<DiaryLog>();
      }
    }

    public CustomerPage(IWebDriver driver)
      : base(driver, By.ClassName("entity-box-header"), 10)
    {
    }

    public void ClickOnMenuButton()
    {
        WaitForElement(By.Id("btnConclusions"), 10).Click();
    }

    public PlacementTestButtonPage ClickOnTheMenuAndGoToPlacementTest()
    {
        ClickOnMenuButton();
        return new PlacementTestButtonPage(driver);
    }
        public TransferPage ClickOnTheMenuAndGoToTransferPage()
    {
        ClickOnMenuButton();
        return new TransferPage(driver);
    }

    public SaleCoursesPage GoToNewSale()
    {
            ClickOnMenuButton();
            WaitForElement(By.Id("btnProcessSale"), 10).Click();
      return new SaleCoursesPage(driver);
    }

    public CancelSalePage ClickOnCancelButtonAndGoToCancelSale()
    {
            SaleLogs.First<DiaryLog>().ClickOnLog();
            WaitForElement(By.Id("btnCancelSale"), 10).Click();
      return new CancelSalePage(driver);
    }

    public SaleCoursesPage ChangelSaleAndGoToSalePage()
    {
            SaleLogs.First<DiaryLog>().ClickOnLog();
            WaitForElement(By.Id("btnChangeSale"), 10).Click();
      return new SaleCoursesPage(driver);
    }

    public AlertPage GoToAlertPage()
    {
            ClickOnMenuButton();
            ClickOnAlertButton();
      return new AlertPage(driver);
    }

    public AlertPage EditAlert()
    {
            ClickOnAlertButton();
      return new AlertPage(driver);
    }

    public AlertPage RemoveAlert()
    {
            ClickOnAlertButton();
      return new AlertPage(driver);
    }

    public SetupMeetingPage SetupMeetingAndGoToCalendar()
    {
            ClickOnMenuButton();
            WaitForElement(By.Id("btnSetUpMeeting"), 10).Click();
      return new SetupMeetingPage(driver);
    }

    public CancelMeetingPage CancelMeetingClickAndGoToCancelMeetingPage()
    {
            WaitForElement(By.XPath("//span[@class='ellipsis' and text()='Meeting Schedule']"), 10).Click();
            WaitForElement(By.Id("btnCancelMeeting"), 10).Click();
            WaitForElement(By.Id("btnSaveMeetingCanceled"), 10).Click();
      return new CancelMeetingPage(driver);
    }

    public CustomerPage RedFrameId()
    {
            driver.ExecuteJavaScript("arguments[0].style.border='3px solid red'", new object[1]
      {
         WaitForElement(By.XPath("//div[@class='left entity-details-info entity-details-info-type' and contains(text(),'INDIVIDUAL #')]"), 10)
      });
      return new CustomerPage(driver);
    }

    public enum LeadLogActionType
    {
     PhoneSchedule,
     MeetingSchedule,
     SaleNextPayment,
     Internal,
     SaleRefund,
     RenewalCall,
    }
    public enum DiaryLogType
    {
    NoAnswer = 1,
    FollowUpCall = 2,
    FollowUpCanceled = 3,
    FollowUpReschedule = 4,
    SetupMeeting = 5,
    MeetingCanceled = 6,
    MeetingReschedule = 7,
    MeetingConfirmed = 8,
    MeetingNoShow = 9,
    LeadTransfered = 10,
    NotInterested = 11,
    BadLead = 12,
    Sale = 13,
    PayBalance = 14,
    General = 15,
    SendSMS = 16,
    LeadRejected = 17,
    ActionExcecuted = 18,
    MeetingOccurred = 19,
    ChangeaSale = 20,
    RefundRequest = 21,
    RefundApproved = 22,
    SaleCancelled = 23,
    SendEmail = 24,
    Incomingcall = 25,
    Outgoingcall = 26,
    SaleConfirmation = 27,
    SubscribeNotification = 28,
    UnsubscribeNotification = 29,
    ChangeSalePeriods = 30,
    OutgoingCallCustomerRelations = 31,
    FollowUpOccurred = 32,
    RenewalCall = 33,
    RenewalCallOccured = 34,
    RenewalCallCanceled = 35,
    Frozen = 36,
    AlertAdded = 37,
    AlertModified = 38,
    AlertRemoved = 39,
    SetUpRenewalCall = 40,
    Transfer = 41,
    PlacementTestAllocated=42
        }
  }
}

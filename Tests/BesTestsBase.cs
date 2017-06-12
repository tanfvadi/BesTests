using BesTests.Pages;
using BesTests.Pages.Meetings;
using BesTests.Pages.Sales;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BesTests.Tests
{
    [TestFixture]
    public class BesTestsBase
    {
        protected IWebDriver driver;

        public TestContext TestContext { get; set; }

        [SetUp]
        public void OpenBrowser()
        {
            driver = new ChromeDriver();
        }

        public BesHomePage LoginAndGoToHome()
        {
            return LoginPage.GoToLoginPage(driver).LoginAndGoToBES("roles.manager", "12345");
        }

        public CustomerPage LoginAndCreateLead()
        {
            return LoginAndGoToHome().GoToAddLead().FillNewLeadAndSave();
        }

        public NotificationPage LoginAndAddNotification()
        {
            return LoginAndGoToHome().GoToNotifications().AddNotification();
        }

        public CustomerPage GoToSalePage()
        {
            return LoginAndGoToHome().GoToCustomerPage("455248674");
        }
        public SaleCoursesPage SaleAdded()
        {
            return GoToSalePage().GoToNewSale();
        }

        public SetupMeetingPage SetupMeeting()
        {
            return GoToSetupMeetingPage().SetupMeeting();
        }

        public SetupMeetingPage GoToSetupMeetingPage()
        {
            return GoToSetupMeetingPage().SetupMeeting();
        }

        [TearDown]
        public void QuitBrowser()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Passed)
            {
                //Take the screenshot
                Screenshot ss = ((ITakesScreenshot) driver).GetScreenshot();
                //Save the screenshot
                ss.SaveAsFile("C:/Users/vadim.t.ECB/Localexplorer.jpeg", ScreenshotImageFormat.Jpeg);
            }
            else // passed
            {
                driver.Quit();
            }


        }

    }
}

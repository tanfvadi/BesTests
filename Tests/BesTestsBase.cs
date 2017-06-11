
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObject3.Pages;

namespace PageObject3.Tests
{
    [TestClass]
    public class BesTestsBase
    {
        protected IWebDriver driver;

        public TestContext TestContext { get; set; }

        [TestInitialize]
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

        [TestCleanup]
        public void QuitBrowser()
        {
            if (TestContext.CurrentTestOutcome == UnitTestOutcome.Failed)
            {
                //Take the screenshot
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                //Save the screenshot
                ss.SaveAsFile("C:/Users/vadim.t.ECB/Localexplorer.jpeg", ScreenshotImageFormat.Jpeg);
            }
            if (TestContext.CurrentTestOutcome == UnitTestOutcome.Passed)
            {
                driver.Quit();
            }

        }

    }
}

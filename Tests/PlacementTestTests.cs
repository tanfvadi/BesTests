using System.Linq;
using BesTests.Pages;
using NUnit.Framework;

namespace BesTests.Tests
{
    [TestFixture]
    public class PlacementTestTests : BesTestsBase
    {
        [Test]
        public void PlacementTestButtonCheck()
        {
            LoginAndGoToHome()
                .GoToAddLead()
                .FillNewLeadAndSave()
                .ClickOnTheMenuAndGoToPlacementTest();          
        }

        [Test]
        public void CheckPlacementTable()
        {
            LoginAndGoToHome()
                .GoToAddLead()
                .FillNewLeadAndSave()
                .ClickOnTheMenuAndGoToPlacementTest()
                .ClickOnPTButton()
                .CheckIfPTTableIsEmpty();
        }


        [Test]
        public void ClickOnPTButtonAndCheckIfAllocateButtonIsEnable()
        {
                 LoginAndGoToHome()
                .GoToAddLead()
                .FillNewLeadAndSave()
                .ClickOnTheMenuAndGoToPlacementTest()
                .ClickOnPTButton()
                .CheckIfAllocateButtonIsEnabled();
        }
        [Test]
        public void LogCheck()
        {
            CustomerPage pt = LoginAndCreateLead();
                 pt.ClickOnTheMenuAndGoToPlacementTest()
                .ClickOnPTButton()
                .ClickOnAllocate();
            Assert.IsTrue(pt.AllLogs.Any<DiaryLog>(a => a.LogType == CustomerPage.DiaryLogType.PlacementTestAllocated));
        }

        [Test]
        public void CheckIfIssueDateIsRed()
        {
            LoginAndGoToHome()
                .GoToAddLead()
                .FillNewLeadAndSave()
                .ClickOnTheMenuAndGoToPlacementTest()
                .ClickOnPTButton()
                .ClickOnAllocate()
                .CheckIfIssueDateIsRed();

        }
        [Test]
        public void CheckIfBEInfoExist()
        {
            LoginAndGoToHome()
                .GoToAddLead()
                .FillNewLeadAndSave()
                .ClickOnTheMenuAndGoToPlacementTest()
                .ClickOnPTButton()
                .ClickOnAllocate()
                .CheckIfBEInfoExist();

        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObject3.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using static PageObject3.Pages.BasePage;
using static PageObject3.Pages.CustomerPage;

namespace PageObject3.Tests
{
    [TestClass]
    public class PlacementTestTests : BesTestsBase
    {
        [TestMethod]
        public void PlacementTestButtonCheck()
        {
            LoginAndGoToHome().GoToAddLead().FillNewLeadAndSave().ClickOnTheMenuAndGoToPlacementTest();          
        }

        [TestMethod]
        public void ClickOnPTButtonAndCheckIfAllocateButtonIsEnable()
        {
                 LoginAndGoToHome()
                .GoToAddLead()
                .FillNewLeadAndSave()
                .ClickOnTheMenuAndGoToPlacementTest()
                .ClickOnPTButton()
                .CheckIfAllocateButtonIsEnabled();
        }
        [TestMethod]
        public void LogCheck()
        {
            CustomerPage pt = LoginAndCreateLead();
                 pt.ClickOnTheMenuAndGoToPlacementTest()
                .ClickOnPTButton()
                .ClickOnAllocate();
            Assert.IsTrue(pt.AllLogs.Any<DiaryLog>(a => a.LogType == DiaryLogType.PlacementTestAllocated));
        }
    }
}

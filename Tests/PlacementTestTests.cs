using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObject3.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using static PageObject3.Pages.BasePage;


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
    }
}

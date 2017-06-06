
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PageObject3.Tests
{
    [TestClass]
    public class AddLeadTest : BesTestsBase
    {
        [TestMethod]
        public void AddLead()
        {
            LoginAndGoToHome().GoToAddLead().FillNewLeadAndSave().RedFrameId();
        }
    }
}


using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BesTests.Tests
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

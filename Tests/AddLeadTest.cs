using NUnit.Framework;

namespace BesTests.Tests
{
    [TestFixture]
    public class AddLeadTest : BesTestsBase
    {
        [Test]
        public void AddLead()
        {
            LoginAndGoToHome().GoToAddLead().FillNewLeadAndSave().RedFrameId();
        }
    }
}

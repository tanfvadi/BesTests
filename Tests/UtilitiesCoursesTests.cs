using BesTests.Pages.Courses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BesTests.Tests
{
    [TestClass]
    public class UtilitiesCoursesTests : BesTestsBase
    {
        private CoursesPage utilitiesCourses;

        [TestInitialize]
        public  void GoToCourses()
        {
            utilitiesCourses = LoginAndGoToHome().GotoUtilitiesCourses();
        }

        [TestMethod]
        public void FindCourse()
        {
            var courseRows = utilitiesCourses
                .CourseSection.SearchCourse("assaf")
                .Courses;
            Assert.AreEqual(6, courseRows.Count);
        }
    }
}

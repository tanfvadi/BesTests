using System;
using BesTests.Pages.Courses;
using System.Linq;
using NUnit.Framework;

namespace BesTests.Tests
{
    [Category("Utilities")]
    [TestFixture]
    public class UtilitiesCoursesTests : BesTestsBase
    {
        private CoursesPage utilitiesCourses;

        [SetUp]
        public  void GoToCourses()
        {
            utilitiesCourses = LoginAndGoToHome().GotoUtilitiesCourses();
        }


        [TestCase("assaf")]
        public void FindCourse(string courseNameToFind)
        {
            var courseRows = utilitiesCourses
                .CourseSection.SearchCourse(courseNameToFind)
                .Courses;
            Assert.AreEqual(6, courseRows.Count);
        }


        [Test]
        public void SelectCourse()
        {
            var courseRow = utilitiesCourses
                .CourseSection.Courses.First().Select();
            Console.WriteLine(courseRow.CourseName);
        }

        [Test]
        public void EditCourse()
        {
            var editCoursePopup = utilitiesCourses
                .CourseSection.Courses.First().EditCourse();
        }

        [Test]
        public void GetCourseId()
        {
            var courseRow = utilitiesCourses
                .CourseSection.Courses.First().CourseId;
            //Console.WriteLine(courseRow.Last().);
        }

        [Test]
        public void IsChacked()
        {
            var courseRow = utilitiesCourses
                .CourseSection.Courses.First().IsChecked();
        }
    }
}

using System;
using System.Collections.Generic;
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
        private CourseSection CourseSection => utilitiesCourses.CourseSection;

        [SetUp]
        public  void GoToCourses()
        {
            utilitiesCourses = LoginAndGoToHome().GotoUtilitiesCourses();
        }


        [TestCase("assaf")]
        public void FindCourse(string courseNameToFind)
        {
            var courseRows = CourseSection.SearchCourse(courseNameToFind).Courses;
            Assert.AreEqual(6, courseRows.Count);
        }


        [Test]
        public void SelectCourse()
        {
            var courseRow = CourseSection.Courses.First().Select();
            Console.WriteLine(courseRow.CourseName);
        }

        [Test]
        public void EditCourse()
        {
            var editCoursePopup = CourseSection.Courses.First().EditCourse();
        }

        [Test]
        public void GetCourseId()
        {
            CourseSection.SearchCourse("Vadim");
            var courseId = CourseSection.Courses.First().CourseId;
            Console.WriteLine("The course ID of : " + CourseSection.Courses.First().CourseName + " Course is " + courseId);

        }

        [Test]
        public void IsChecked()
        {
            var courseRow = CourseSection.Courses.First().IsChecked();
        }

        [Test]
        public void PrintCourseNames()
        {
            CourseSection.SearchCourse("vadim");
            IEnumerable<string> courseNames = CourseSection.Courses.Select(row => row.CourseName);
            foreach (var courseName in courseNames)
            {
                Console.WriteLine(courseName);
            }   
        }
    }
}

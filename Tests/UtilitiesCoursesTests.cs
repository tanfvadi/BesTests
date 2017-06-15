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

        private EditCoursePopup editCoursesPage;

        private CourseSection CourseSection => utilitiesCourses.CourseSection;
       // private EditCoursePopup EditCoursePopup => utilitiesCourses.EditCoursePopup.Name;

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

        [Test]
        public void TypeOfFirstCourse()
        {
            CourseSection.SearchCourse("vadim");
            var firstRow = CourseSection.Courses.First();
            Console.WriteLine(" The type of " + firstRow.CourseName + " course is " + firstRow.CourseType);
        }

        [Test]
        public void FindFirstCourseByType()
        {
            var firstFixed = CourseSection.FindFirstCourse(CourseType.Fixed);
            var firstFlex = CourseSection.FindFirstCourse(CourseType.Flexible);
            var firstPrivate = CourseSection.PrivateCourses.First();
            Assert.AreEqual(CourseType.Private,firstPrivate.CourseType);
        }

        [Test]
        public void EditCoursePopupData()
        {
            CourseSection
                .Courses
                .First()
                .EditCourse()
                .Name()
                .Description()
                .Currency()
                .NotSalable()
                .SalableOnlyInPackage();
        }

        [Test]
        public void EditCoursePopupCourseType()
        {
            var firstFixed = CourseSection.FindFirstCourse(CourseType.Fixed);
            var firstFlex = CourseSection.FindFirstCourse(CourseType.Flexible);
            var firstPrivate = CourseSection.PrivateCourses.First();
            Assert.AreEqual(CourseType.Private, firstPrivate.CourseType);
        }
    }
}


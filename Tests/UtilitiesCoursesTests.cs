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
            Console.WriteLine(firstPrivate.CourseType);
        }

        [Test]
        public void EditCourseData()
        {
            //CourseSection.SearchCourse("private");
            var courseRow = CourseSection
                .Courses
                .First();

            var editCoursePopup = courseRow
                .EditCourse();

            Console.WriteLine("Name Before change: " + editCoursePopup.Name);
            editCoursePopup.Name = " NEW NAME ";
            Console.WriteLine("Name After change: " + editCoursePopup.Name);
            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine("Description Before change: " + editCoursePopup.Description);
            editCoursePopup.Description = " NEW Description";
            Console.WriteLine("Description After change: " + editCoursePopup.Description);
            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine("Currency: " + editCoursePopup.Currency);
            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine("Course type: " + editCoursePopup.CourseType);
            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine("Topic lessons before change: " + editCoursePopup.TopicLessons);
            editCoursePopup.TopicLessons = TopicLessons.TopicLessonsAdvanced;
            Console.WriteLine("Topic lessons after change: " + editCoursePopup.TopicLessons);
            Console.WriteLine("-------------------------------------------------------");

            editCoursePopup.CheckIfSalableOnlyInPackageIsChecked();
            Console.WriteLine("-------------------------------------------------------");

            editCoursePopup.CheckIfNotSalableIsChecked();
            Console.WriteLine("-------------------------------------------------------");

            editCoursePopup.Save();

            editCoursePopup.Cancel();

            //CourseSection
            //  .Courses
            //  .First()
            //editCoursePopup
            //.Name
            //.Description()
            //.Currency()
            //.NotSalable()
            //.SalableOnlyInPackage()
            //.PrintCourseType()
            //.SelectLastTopicLessons()
            //.Cancel()
            //.Save();
        }


        [Test]
        public void CheckIfRadioButtonsChecked()
        {
            CourseSection
                .Courses
                .First()
                .EditCourse()
                .CheckIfNotSalableIsChecked()
                .CheckIfSalableOnlyInPackageIsChecked();

        }

        //[Test]
        //public void CheckTopicLessons()
        //{
        //    var courseRow = CourseSection
        //        .Courses
        //        .First();
        //    var editCoursePopup = courseRow
        //        .EditCourse().TopicLessons == TopicLessons.TopicLessonsAdvanced;
        //    //Assert.AreEqual(TopicLessons.TopicLessonsAdvanced, );
        //    //Console.WriteLine(courseRow.TopicLessons == TopicLessons.TopicLessonsAdvanced);
        //}

    }
}


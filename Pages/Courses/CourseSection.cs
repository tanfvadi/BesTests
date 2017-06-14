using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using TechTalk.SpecFlow.Bindings;

namespace BesTests.Pages.Courses
{
    public class CourseSection : BasePage
    {
        public CourseSection(IWebDriver driver): base(driver,By.CssSelector(".course-column"))
        {
        }

        public List<CourseRow> Courses => 
            FindElementsByCss<CourseRow>("li.course:not(.hidden)");

        public List<CourseRow> FixedCourses => Courses.Where(a=>a.CourseType== CourseType.Fixed).ToList();
        public List<CourseRow> FlexibleCourses => Courses.Where(a => a.CourseType == CourseType.Flexible).ToList();
        public List<CourseRow> PrivateCourses=> Courses.Where(a => a.CourseType == CourseType.Private).ToList();


        public CourseSection SearchCourse(string courseName)
        {
            //var oldCount = Courses.Count;
            WaitForElement(By.Id("filterCourse")).SendKeys(courseName);
            //WaitUntil(o => Courses.Count != oldCount);
            return this;
        }

        public CourseRow FindFirstCourse(CourseType courseType)
        {
            return Courses.First(a => a.CourseType == courseType);
        }
    }
}
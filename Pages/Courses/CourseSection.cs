using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace BesTests.Pages.Courses
{
    public class CourseSection : BasePage
    {
        public CourseSection(IWebDriver driver): base(driver,By.CssSelector(".course-column"))
        {
        }

        public List<CourseRow> Courses => 
            FindElementsByCss<CourseRow>("li.course:not(.hidden)");


        public CourseSection SearchCourse(string courseName)
        {
            //var oldCount = Courses.Count;
            WaitForElement(By.Id("filterCourse")).SendKeys(courseName);
            //WaitUntil(o => Courses.Count != oldCount);
            return this;
        }

   
    }
}
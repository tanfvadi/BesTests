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


        public CourseSection SearchCourse(string courseName)
        {
            //var oldCount = Courses.Count;
            WaitForElement(By.Id("filterCourse")).SendKeys(courseName);
            //WaitUntil(o => Courses.Count != oldCount);
            return this;
        }

        public CourseSection PrintAllCourses()
        {
            var courseNames=WaitForElement(By.CssSelector(".course-column")).Text;
            Console.WriteLine(courseNames);
            return this;
        }

        
    }
}
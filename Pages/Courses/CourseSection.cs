using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using OpenQA.Selenium;

namespace BesTests.Pages.Courses
{
    public class CourseSection : BasePage
    {
        public CourseSection(IWebDriver driver): base(driver,By.CssSelector(".course-column"))
        {
        }

        public List<CourseRow> Courses
        {
            get
            {
                //Find all courses rows IWebElements
                WaitForElements(By.CssSelector("li.course:not(.hidden)"));
                //For each courseRow element return New CourseRow and send him(IWebElement,driver)
                return null;
            }
        }

        public CourseSection SearchCourse(string courseName)
        {
            var oldCount = Courses.Count;
            WaitForElement(By.Id("filterCourse")).SendKeys(courseName);
            WaitUntil(o => Courses.Count != oldCount);
            return this;
        }
    }
}
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace BesTests.Pages.Courses
{
    public class CourseRow
    {
        private readonly IWebDriver driver;
        private readonly IWebElement rowElement;
        public CourseRow(IWebElement rowElement, IWebDriver driver)
        {
            this.rowElement = rowElement;
            this.driver = driver;
        }

        public string CourseId => rowElement.GetAttribute("data-course-id");
        public string CourseName => rowElement.FindElement(By.CssSelector("div.course-name")).Text;
        public CourseType CourseType => (CourseType)int.Parse(rowElement.GetAttribute("data-course-type"));

        public TopicLessons TopicLessons=> (TopicLessons)int.Parse(rowElement.GetAttribute("id"));

        public EditCoursePopup EditCourse()
        {
            Actions action = new Actions(driver);
            var editButton = rowElement.FindElement(By.CssSelector(".edit-btn.course"));
            action.MoveToElement(rowElement).Build().Perform();
            editButton.Click();
            return new EditCoursePopup(driver);
        }

        public bool IsChecked()
        {
            return rowElement.FindElement(By.CssSelector("input[type='radio']")).Selected;

        }

        public CourseRow Select()
        {
            rowElement.Click();
            return this;
        }
    }
}
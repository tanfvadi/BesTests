using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace BesTests.Pages.Courses
{
    public class CourseRow
    {
        private readonly IWebElement _rowElement;
        private readonly IWebDriver _driver;
        

        public CourseRow(IWebElement rowElement,IWebDriver driver)
        {
            _rowElement = rowElement;
            _driver = driver;
        }

        public string CourseName => _rowElement.FindElement(By.CssSelector("div.course-name")).Text;
        

        public string CourseId => _rowElement.FindElement(By.CssSelector("label['data-courseid']")).Text;
        
        public CourseType CourseType
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }


        public CourseRow Select()
        {
            _rowElement.Click();
            return this;
        }

        public bool IsChecked()
        {
          return _rowElement.FindElement(By.CssSelector("input[type='radio']")).Selected;

        }

        public EditCoursePopup EditCourse()
        {
           Actions action = new Actions(_driver);
            var editButton = _rowElement.FindElement(By.CssSelector(".edit-btn.course"));
            action
                .MoveToElement(editButton)
                .Click()
                .Build()
                .Perform();
           return new EditCoursePopup();
        }
    }
}
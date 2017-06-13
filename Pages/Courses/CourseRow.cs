using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace BesTests.Pages.Courses
{
    public class CourseRow
    {
        private readonly IWebElement rowElement;
        private readonly IWebDriver driver;
        

        public CourseRow(IWebElement rowElement,IWebDriver driver)
        {
            this.rowElement = rowElement;
            this.driver = driver;
        }

        public string CourseName => rowElement.FindElement(By.CssSelector("div.course-name")).Text;
        

        public string CourseId => rowElement.FindElement(By.CssSelector("label['data-courseid']")).Text;
        
        public CourseType CourseType
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }


        public CourseRow Select()
        {
            rowElement.Click();
            return this;
        }

        public bool IsChecked()
        {
          return rowElement.FindElement(By.CssSelector("input[type='radio']")).Selected;

        }

        public EditCoursePopup EditCourse()
        {
           Actions action = new Actions(driver);
           var editButton = rowElement.FindElement(By.CssSelector(".edit-btn.course"));
            action.MoveToElement(rowElement).Build().Perform();
            editButton.Click();
           return new EditCoursePopup(driver);
        }
    }
}
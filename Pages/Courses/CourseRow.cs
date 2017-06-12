using OpenQA.Selenium;

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

        public string CourseId => _rowElement.FindElement(By.CssSelector("label[data-courseid']")).Text;

        public CourseRow CourseID()
        {
         
            return this;
        }

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

        public CourseRow IsChecked()
        {
            _rowElement.Selected.ToString();
            return this;
        }

        public EditCoursePopup EditCourse()
        {
            throw new System.NotImplementedException();
        }
    }
}
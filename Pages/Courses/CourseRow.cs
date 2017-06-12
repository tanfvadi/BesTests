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

        public string CourseName
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public int CourseID
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public CourseType CourseType
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }


        public CourseRow Check()
        {
            throw new System.NotImplementedException();
        }

        public bool IsChecked()
        {
            throw new System.NotImplementedException();
        }

        public EditCoursePopup EditCourse()
        {
            throw new System.NotImplementedException();
        }
    }
}
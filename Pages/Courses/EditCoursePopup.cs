using OpenQA.Selenium;

namespace BesTests.Pages.Courses
{
    public class EditCoursePopup : BasePage
    {
        public string Name
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string Description
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string Currency
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

        public TopicLessons TopicLessons
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public bool SalableOnlyInPackage
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public bool NotSalable
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public CourseSection Save()
        {
            throw new System.NotImplementedException();
        }

        public CourseSection Cancel()
        {
            throw new System.NotImplementedException();
        }

        public EditCoursePopup(IWebDriver driver) : base(driver, By.CssSelector(".edit-btn.course"))
        {
        }
    }
}
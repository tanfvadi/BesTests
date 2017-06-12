using OpenQA.Selenium;

namespace BesTests.Pages.Courses
{
    public class CoursesPage : BasePage
    {

        public CoursesPage(IWebDriver driver) : base(driver, By.Id("course-columns-wrapper"))
        {
        }

        public CourseSection CourseSection
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
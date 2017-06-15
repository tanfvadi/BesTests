using System;
using OpenQA.Selenium;

namespace BesTests.Pages.Courses
{
    public class EditCoursePopup:BasePage
    {
        private readonly IWebDriver driver;
        private readonly IWebElement popupElement;
        //public EditCoursePopup(IWebElement popupElement, IWebDriver driver)
        //{
        //    this.popupElement = popupElement;
        //    this.driver = driver;
        //}

        public TopicLessons TopicLessons =>(TopicLessons)int.Parse(popupElement.GetAttribute("topic-lessons"));

        public CourseType CourseType => (CourseType)int.Parse(popupElement.GetAttribute("type"));

        public EditCoursePopup Name()
        {
            var name=WaitForElement(By.Id("courseName"), 10).Text;
            Console.WriteLine(name);
            return this;
        }
        public EditCoursePopup Description()
        {
            var desc= WaitForElement(By.Id("description"), 10).Text;
            Console.WriteLine(desc);
            return this;
        }

        public EditCoursePopup Currency()
        {

            var cur=WaitForElement(By.Id("currency"), 10).Text;
            Console.WriteLine(cur);
            return this;
        }

        //public EditCoursePopup CourseType()
        //{
        //    var type=WaitForElement(By.Id("type"), 10).Text;
        //    Console.WriteLine(type);
        //    return this;
        //}

        //public EditCoursePopup TopicLessons()
        //{
        //    WaitForElement(By.Id("topic-lessons"), 10).Click();
        //    return this;
        //}

        public EditCoursePopup SalableOnlyInPackage()
        {
            WaitForElement(By.Id("courseIsSalableOnlyInPackage")).Click();
            return this;
        }

        public EditCoursePopup NotSalable()
        {
            WaitForElement(By.Id("courseIsNotSalable")).Click();
            return this;

        }

        public CourseSection Save()
        {
            throw new System.NotImplementedException();
        }

        public CourseSection Cancel()
        {
            var cancel=WaitForElement(By.Id("cancel-btn")).Displayed;
            if (cancel)
            {
                Console.WriteLine("The Cancel button is appear");
            }
            Console.WriteLine("The Cancel button is not appear");          
            return new CourseSection(driver);

        }

        public EditCoursePopup(IWebDriver driver) : base(driver, By.XPath("//div[@class='header' and text()='Edit Course']"))
        {
        }
    }
}
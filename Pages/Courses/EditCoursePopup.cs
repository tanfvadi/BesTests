using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace BesTests.Pages.Courses
{
    public class EditCoursePopup:BasePage
    {

        public EditCoursePopup(IWebDriver driver) : base(driver, By.XPath("//div[@class='header' and text()='Edit Course']"))
        {
        }

        private readonly IWebDriver driver;
        private readonly IWebElement popupElement;
        //public EditCoursePopup(IWebElement popupElement, IWebDriver driver)
        //{
        //    this.popupElement = popupElement;
        //    this.driver = driver;
        //}

        //public TopicLessons TopicLessons =>(TopicLessons)int.Parse(popupElement.GetAttribute("topic-lessons"));

        //public CourseType CourseType => (CourseType)int.Parse(popupElement.GetAttribute("type"));

        public EditCoursePopup Name()
        {
            var name=WaitForElement(By.Id("courseName"), 10).GetAttribute("value");
            Console.WriteLine("Course name: " + name);
            return this;
        }
        public EditCoursePopup Description()
        {
            var desc= WaitForElement(By.Id("description"), 10).GetAttribute("value");
            Console.WriteLine("Description: " + desc);
            return this;
        }

        public EditCoursePopup Currency()
        {

            var cur=WaitForElement(By.Id("currency"), 10).Text;
            Console.WriteLine("Currency : " + cur);
            return this;
        }

        public EditCoursePopup CourseType()
        {
            var type = WaitForElement(By.Id("type"), 10).Text;
            Console.WriteLine("Course type : " + type);
            return this;
        }

        public EditCoursePopup TopicLessons()
        {
            WaitForElement(By.Id("topic-lessons"), 10).Click();
            new SelectElement(WaitForElement(By.Id("topic-lessons"), 10)).SelectByIndex(3);
            Save();
            return this;
        }

        public EditCoursePopup SalableOnlyInPackage()
        {
            WaitForElement(By.Id("courseIsSalableOnlyInPackage")).Click();
            Console.WriteLine("Salable Only In Package option is selected");
            return this;
        }
        public EditCoursePopup CheckIfSalableOnlyInPackageIsChecked()
        {
            if (WaitForElement(By.Id("courseIsSalableOnlyInPackage")).Selected)
            {
                Console.WriteLine("Salable Only In Package option is selected");
            }
            else
            {
                Console.WriteLine("Salable Only In Package option don't selected");
            }
            return this;
        }

        public EditCoursePopup CheckIfNotSalableIsChecked()
        {
            if (WaitForElement(By.Id("courseIsNotSalable")).Selected)
            {
                Console.WriteLine("Not salable option is selected");
            }
            else
            {
                Console.WriteLine("Not salable option don't selected");
            }
            return this;
        }
        public EditCoursePopup NotSalable()
        {
            WaitForElement(By.Id("courseIsNotSalable")).Click();
            Console.WriteLine("Not Salable option is selected");
            return this;

        }

        public CourseSection Save()
        {
            WaitForElement(By.Id("save-btn")).Click();
            //Thread.Sleep(1000);
            WaitForElement(By.ClassName("confirm")).Click();
            return new CourseSection(driver);
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


    }
}
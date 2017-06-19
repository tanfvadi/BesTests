using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Support.PageObjects;

namespace BesTests.Pages.Courses
{
    public class EditCoursePopup : BasePage
    {

        public EditCoursePopup(IWebDriver driver) : base(driver,
            By.XPath("//div[@class='header' and text()='Edit Course']"))
        {
        }

        //private readonly IWebDriver driver;
        //private readonly IWebElement popupElement;
        //public EditCoursePopup(IWebElement popupElement, IWebDriver driver)
        //{
        //    this.popupElement = popupElement;
        //    this.driver = driver;
        //}

        //public TopicLessons TopicLessons =>(TopicLessons)int.Parse(popupElement.GetAttribute("topic-lessons"));

        //public CourseType CourseType => (CourseType)int.Parse(popupElement.GetAttribute("type"));

        public EditCoursePopup PrintName()
        {
            Console.WriteLine(Name);
            return this;
        }


        public string Name
        {
            get { return GetValue(By.Id("courseName")); }
            set { FillText(By.Id("courseName"), value); }
        }


        public string Description
        {
            get { return GetValue(By.Id("description")); }
            set { FillText(By.Id("description"), value); }
        }

        public string Currency
        {
            get
            {
                //return GetTe(By.Id("currency"));
                return WaitForElement(By.Id("currency")).Text;
            }
        }

        public string CourseType
        {
            get { return WaitForElement(By.Id("type")).Text; }
        }

        public TopicLessons TopicLessons
        {
            get
            {
                //Return selected option parsed to enum TopicLessons
                var value = int.Parse(FindDropDown(By.Id("topic-lessons")).SelectedOption.GetValue());
                return (TopicLessons) value;
            }
            set
            {
                //Select option from combo box by enum value
                FindDropDown(By.Id("topic-lessons")).SelectByValue(((int) value).ToString());
            }
        }

        public void FlexAndPrivate()
        {
            var flexOrPrivate=WaitForElement(By.Id("type")).Text;
            if (flexOrPrivate== "Flexible" || flexOrPrivate =="Private")
            {
                WaitForElement(By.Id("usage")).Click();
                //new SelectElement(WaitForElement(By.Id("usage']"))).SelectByIndex(2);
                new SelectElement(WaitForElement(By.Id("usage']"))).SelectByIndex(2);
                WaitForElement(By.Id("lesson-default-duration")).Click();
                new SelectElement(WaitForElement(By.Id("lesson-default-duration']"))).SelectByIndex(5);
                Save();
            }
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
            Console.WriteLine("After selecting-not Salable option is selected");
            return this;

        }

        public CourseSection Save()
        {
            WaitForElement(By.Id("save-btn")).Click();
            WaitForElement(By.ClassName("confirm")).Click();
            return new CourseSection(driver);
        }

        public CourseSection Cancel()
        {
            WaitForElement(By.Id("cancel-btn")).Click();         
            return new CourseSection(driver);
        }

    }
}
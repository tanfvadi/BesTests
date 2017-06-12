using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium;

namespace BesTests.Pages.EmploeesPage
{
    public class UserBranchPage
    {
        private IWebDriver driver;
        public string Branch;
        public IWebElement rowElement;
        private IWebElement rowWebElement;
        public EmployeeUserBranch UserBranch { get; internal set; }

        public UserBranchPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public UserBranchPage(IWebElement rowWebElement, IWebDriver driver)
        {
            this.rowWebElement = rowWebElement;
            this.driver = driver;
        }

        public void GetBranchesFromEmployeesPage()
        {
            Thread.Sleep(1000);
            IList<IWebElement> all = driver.FindElements(By.CssSelector("div.utilities-employees-table-branches"));
            foreach (IWebElement element in all)
                if (element.Text.Contains("Ashdod"))
                Console.WriteLine("{0}", element.Text);
        }

        public enum EmployeeUserBranch
        {
            Gal12,
            BeerSheva,
            Jerusalem,
            KiriatMoztkin,
            Raanana,
            Raanana1,
            Rehovot,
            Ashdod,
            Ashkelon,
            בתים,
            חדרה,
            חיפה,
            LevHaMefratz,
            טבריה,
            כרמיאל,
            נתניה,
            PetahTikva,
            RishonLetzion,
            RamatGan
        }
    }
}

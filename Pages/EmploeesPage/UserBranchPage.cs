using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PageObject3.Pages
{
    public class UserBranchPage
    {
        private IWebDriver driver;
        public string Branch;
        public IWebElement rowElement;

        //public UserBranchPage(IWebElement rowElement, IWebDriver driver)
        //{
        //    this.rowElement = rowElement;
        //    this.driver = driver;
        //}

        public UserBranchPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GetBranchesFromEmployeesPage()
        {
            Thread.Sleep(1000);
            foreach (IWebElement element in driver.FindElements(By.CssSelector("div.utilities-employees-table-branches")))
            if (element.Text.Contains("Jerusalem"))
            Console.WriteLine("{0}", element.Text);
        }

        public enum EmployeeUserBranch
        {
            gal12,
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

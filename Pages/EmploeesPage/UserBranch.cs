using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject3.Pages.EmploeesPage
{
    public class UserBranch
    {
        private IWebDriver driver;
        public string BranchName;
        public IWebElement rowElement;

        public UserBranch(IWebElement rowElement, IWebDriver driver)
        {
            this.rowElement = rowElement;
            this.driver = driver;
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
            RamatGan,
        }
    }
}

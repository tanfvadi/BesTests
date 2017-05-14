
using OpenQA.Selenium;
using System;
using System.Linq;
using System.Threading;

namespace PageObject3.Pages
{
  public class UserRolePage
  {
    private IWebDriver driver;
    public string Role;
    public IWebElement rowElement;
        private IWebElement rowWebElement;

        public EmployeeUserRole UserRole { get; internal set; }

        //public BasHomePage(IWebElement rowElement, IWebDriver driver)
        //{
        //  this.rowElement = rowElement;
        //  this.driver = driver;
        //}

        public UserRolePage(IWebDriver driver)
    {
        this.driver = driver;
    }

        public UserRolePage(IWebElement rowWebElement, IWebDriver driver)
        {
            this.rowWebElement = rowWebElement;
            this.driver = driver;
        }

        public void SelectRoles()
    {
        Thread.Sleep(1000);
        foreach (IWebElement element in driver.FindElements(By.XPath("//div[@class='utilities-employees-table-roles']")))     
        if (element.Text.Contains("Rep"))
        Console.WriteLine(element.Text);
    }

    public enum EmployeeUserRole
    {
    Manager,
    AreaManager,
    CallCenterManager,
    BranchManager,
    PedagogicalManager,
    Rep,
    Telerep,
    Teacher,
    Accountant,
    Administrator,
    Receptionist,
    CustomerRelations,
    }
  }
}

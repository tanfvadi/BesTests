
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
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
    public UserRolePage(IWebElement rowWebElement, IWebDriver driver)
    {
        this.rowWebElement = rowWebElement;
        this.driver = driver;
    }

        public UserRolePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SelectRoles()
    {
        Thread.Sleep(1000);
        IList<IWebElement> all = driver.FindElements(By.XPath("//div[@class='utilities-employees-table-roles']"));
        foreach (IWebElement element in all)
        {
            if (element.Text.Contains("Manager"))
            Console.WriteLine(element.Text);
        }

        //Thread.Sleep(1000);
        //foreach (IWebElement element in driver.FindElements(By.XPath("//div[@class='utilities-employees-table-roles']")))     
        //if (element.Text.Contains("Rep"))
        //Console.WriteLine(element.Text);
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

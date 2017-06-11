using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace PageObject3.Pages.EmploeesPage
{
    public class EmoloyeeRow
    {


        private readonly IWebElement _myRow;
        private readonly IWebDriver _driver;

        private List<IWebElement> RowCol => _myRow.FindElements(By.CssSelector("td")).ToList();

        public EmoloyeeRow(IWebElement myRow, IWebDriver driver)
        {
            _myRow = myRow;
            _driver = driver;
        }

        public int EmployeeID => int.Parse(RowCol[0].Text);

        public string Name => RowCol[0].Text;
        public string Branch => RowCol[1].Text;
        public List<EmployeeRole> Roles
        {
            get
            {
                var strings = RowCol[2].Text.Split(',');
                return strings.Select(a => a.ParseToEnum<EmployeeRole>()).ToList();
            }
        }

        public bool IsMessageSelected => MessageCheckbox.Selected;

        private IWebElement MessageCheckbox => _myRow.FindElement(By.CssSelector(".utilities-employees-msg-chk"));

        public AddEditEmployeePage Edit()
        {
            _myRow.FindElement(By.CssSelector(".utilities-employees-edit-btn")).Click();
            return new AddEditEmployeePage(_driver);
        }

        public EmoloyeeRow CheckMessage()
        {
            if (!IsMessageSelected)
                MessageCheckbox.Click();
            return this;
        }
    }


}

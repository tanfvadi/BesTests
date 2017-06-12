// Decompiled with JetBrains decompiler
// Type: PageObject3.Pages.TransferPage
// Assembly: PageObject3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0D9DC055-2B5D-4B03-9C15-724F3DFE242F
// Assembly location: C:\Users\vadim.t.ECB\Documents\Visual Studio 2015\Projects\PageObject3\PageObject3\bin\Debug\PageObject3.dll

using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BesTests.Pages
{
  public class TransferPage : BasePage
  {
    public TransferPage(IWebDriver driver)
      : base(driver, By.Id("btnTransfer"), 10)
    {
    }

    public TransferPage TransferCustomer()
    {
            WaitForElement(By.Id("btnTransfer"), 10).Click();
            WaitForElement(By.CssSelector(".transfer-combo.cmbTransferConsultant"), 10).Click();
            new SelectElement(WaitForElement(By.CssSelector(".transfer-combo.cmbTransferConsultant"), 10)).SelectByIndex(7);
            WaitForElement(By.CssSelector(".txbTransferPicker.hasDatepicker"), 10).Click();
            WaitForElement(By.CssSelector(".ui-icon.ui-icon-circle-triangle-e"), 10).Click();
            WaitForElement(By.XPath("//a[@class='ui-state-default' and text()='1']"), 10).Click();
            Thread.Sleep(3000);
            WaitForElement(By.ClassName("txbTransferComment"), 10).Click();
            WaitForElement(By.ClassName("txbTransferComment"), 10).SendKeys("My Transfer");
            WaitForElement(By.Id("btnSaveTransfer"), 10).Click();
            return new TransferPage(driver);
    }
  }
}

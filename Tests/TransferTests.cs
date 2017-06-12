// Decompiled with JetBrains decompiler
// Type: PageObject3.Tests.TransferTests
// Assembly: PageObject3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0D9DC055-2B5D-4B03-9C15-724F3DFE242F
// Assembly location: C:\Users\vadim.t.ECB\Documents\Visual Studio 2015\Projects\PageObject3\PageObject3\bin\Debug\PageObject3.dll

using System.Linq;
using BesTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BesTests.Tests
{
  [TestClass]
  public class TransferTests : BesTestsBase
  {
    [TestMethod]
    public void TransferCustomer()
    {
      CustomerPage lead = LoginAndCreateLead();
      lead.ClickOnTheMenuAndGoToTransferPage().TransferCustomer();
      Assert.IsTrue(lead.AllLogs.Any<DiaryLog>(a => a.LogType == CustomerPage.DiaryLogType.Transfer));
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: PageObject3.Tests.WrongUsernameTest
// Assembly: PageObject3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0D9DC055-2B5D-4B03-9C15-724F3DFE242F
// Assembly location: C:\Users\vadim.t.ECB\Documents\Visual Studio 2015\Projects\PageObject3\PageObject3\bin\Debug\PageObject3.dll

using System;
using BesTests.Pages;
using NUnit.Framework;

namespace BesTests.Tests
{
    [TestFixture]
  public class WrongUsernameTest : BesTestsBase
  {
    [Test]
    public void WrongUsername()
    {
      LoginPage loginPage = LoginPage.GoToLoginPage(driver);
      loginPage.LoginExpectingError("fffff", "12345");
      string username = loginPage.GetUsername();
      Assert.AreEqual("fffff", username);
      Console.WriteLine("Wrong username " + username);
    }
  }
}

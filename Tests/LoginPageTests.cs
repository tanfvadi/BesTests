﻿// Decompiled with JetBrains decompiler
// Type: PageObject3.Tests.LoginPageTests
// Assembly: PageObject3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0D9DC055-2B5D-4B03-9C15-724F3DFE242F
// Assembly location: C:\Users\vadim.t.ECB\Documents\Visual Studio 2015\Projects\PageObject3\PageObject3\bin\Debug\PageObject3.dll

using BesTests.Pages;
using NUnit.Framework;

namespace BesTests.Tests
{
    [TestFixture]
  public class LoginPageTests : BesTestsBase
  {
    [Test]
    public void LoginSuceessTest()
    {
      LoginPage.GoToLoginPage(driver).LoginAndGoToBES("roles.manager", "12345");
    }
  }
}

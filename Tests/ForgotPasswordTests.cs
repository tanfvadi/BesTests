// Decompiled with JetBrains decompiler
// Type: PageObject3.Tests.ForgotPasswordTests
// Assembly: PageObject3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0D9DC055-2B5D-4B03-9C15-724F3DFE242F
// Assembly location: C:\Users\vadim.t.ECB\Documents\Visual Studio 2015\Projects\PageObject3\PageObject3\bin\Debug\PageObject3.dll

using System;
using BesTests.Pages;
using NUnit.Framework;

namespace BesTests.Tests
{
    [TestFixture]
  public class ForgotPasswordTests : BesTestsBase
  {
    [Test]
    public void ForgotPassword()
    {
      ForgotPasswordPage forgotPasswordPage = LoginPage.GoToLoginPage(driver).GoToForgotPasswordPage();
      forgotPasswordPage.ResetPassword("yonni.hoch@ecb.co.il").SaveImage();
      Assert.AreEqual("BurlingtonEnglish has sent you an email with instructions for resetting your password. Please check your mailbox.", forgotPasswordPage.GetSuccessMessageText);
      Console.WriteLine("Forgot Password Success!");
    }
  }
}

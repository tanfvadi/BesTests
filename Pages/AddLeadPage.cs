
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;

namespace PageObject3.Pages
{
  public class AddLeadPage : BasePage
  {
    public AddLeadPage(IWebDriver driver): base(driver, By.XPath("//div[@class='left entity-details-action' and text()='NEW :']"), 10)
    {
    }

    public CustomerPage FillNewLeadAndSave()
    {
      driver.ExecuteJavaScript("var makeRandomDigits = function(){ var text = ''; var possible = '0123456789'; for (var i = 0; i < 9; i++) text += possible.charAt(Math.floor(Math.random() * possible.length)); return text; }; var makeLegalTzNumber = function (num) { var originalTz = new String(num.substr(0, 8)); for (var j = 0; j <= 9; j++) { tz = originalTz + j.toString(); console.log('in makeLegalTzNumber call LegalTz'); if (LegalTz(tz)) return tz; } return ''; }; var makeRandomText = function () { var text = ''; var possible = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789'; for (var i = 0; i < 5; i++) text += possible.charAt(Math.floor(Math.random() * possible.length)); return text; }; var entity = makeRandomText(); if (entity != null) { window.globalRandomEntityName = entity; var randomPhone = makeRandomDigits(); var tz = makeLegalTzNumber(randomPhone); $('.entity-details-firstname').val(entity + '_fn'); $('.entity-details-middlename').val(entity + '_fn'); $('.entity-details-lastname').val(entity + '_ln'); $('.entity-details-phone').val(randomPhone); $('.entity-details-cellphone').val('052' + randomPhone); $('.entity-details-email').val(entity + '@' + entity + '.com'); $('.entity-details-branch').val($('.entity-details-branch option:last').val()); $('.entity-details-identity').val(tz); $('.entity-details-addressee').val(entity + '-FAO'); $('.entity-details-state').attr('data-stateid','52'); $('.entity-details-state').val('Acre'); $('.entity-details-cities').attr('data-cityid','1'); $('.entity-details-street').val(entity + '-street'); $('.entity-details-number').val('streetNum'); $('.entity-details-apartmentnumber').val('aptnum'); $('.entity-details-postcode').val('Postcode'); $('.entity-details-btn-save').click(); }");
      Console.WriteLine("Customer entityID:" + WaitForElement(By.XPath("//div[@class='left entity-details-info entity-details-info-type' and contains(text(),'INDIVIDUAL #')]"), 10).Text.Replace("INDIVIDUAL #", ""));
      return new CustomerPage(driver);
    }
  }
}

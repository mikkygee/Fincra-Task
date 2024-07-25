using FincraAssessment.TestSetup;
using FincraAssessment.TestUtils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FincraAssessment.PageObject
{
    public class LoginPage: BaseSetup
    {
        By Email = By.XPath("//input[@id='email']");
        By Password = By.XPath("//input[@id='password']");
        By KeepMeSignedInCheck = By.XPath("//body/div[@id='__next']/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/form[1]/div[4]/label[1]/span[2]");
        By LoginButton = By.XPath("//body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/form[1]/button[1]");
        By ForgotPassButton = By.XPath("//a[contains(text(),'Forgot login details?')]");
        By CreateAccount = By.XPath("//a[contains(text(),'Create Account')]");

        public void login(string email, string pass)
        {
          BrowserActions.Type(Email, email); 
          BrowserActions.Type(Password, pass);
          BrowserActions.Click(LoginButton);
        }
     }
}


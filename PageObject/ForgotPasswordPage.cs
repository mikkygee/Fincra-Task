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
    public class ForgotPasswordPage
    {
        By ForgotPassButton = By.XPath("//a[contains(text(),'Forgot login details?')]");
        By ForgotPassEmail = By.XPath("//input[@id='email']");
        By ResetPassButton = By.XPath("//span[contains(text(),'Send Password Reset Link')]");
        By BackToLogin = By.XPath("//a[contains(text(),'Return to Login')]");

        public void ClickForgotPassword()
        {
            BrowserActions.Click(ForgotPassButton);
        }

        public void EnterValidEmail(string email)   
        {
            BrowserActions.Click(ForgotPassButton);
            BrowserActions.Type(ForgotPassEmail, email);
            BrowserActions.Click(ResetPassButton);
            
        }
        public void ReturnToLogin()
        {
            BrowserActions.Click(ForgotPassButton);
            Thread.Sleep(3000);
            BrowserActions.Click(BackToLogin);
        }
    }
}

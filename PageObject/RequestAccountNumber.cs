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
    public class RequestAccountNumber : BaseSetup
    {
        By Email = By.XPath("//input[@id='email']");
        By Password = By.XPath("//input[@id='password']");
        By KeepMeSignedInCheck = By.XPath("//body/div[@id='__next']/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/form[1]/div[4]/label[1]/span[2]");
        By LoginButton = By.XPath("//body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/form[1]/button[1]");
        By ForgotPassButton = By.XPath("//a[contains(text(),'Forgot login details?')]");
        By CreateAccount = By.XPath("//a[contains(text(),'Create Account')]");
        By RequestVirtualAccount = By.XPath("//span[contains(text(),'Request Virtual Account')]");
        By ContinueButton = By.XPath("//div[@class='text-sm mt-6']//button[@type='submit']");
        By CloseModal = By.XPath("//img[@src='/images/close.svg']");
        By RequestAccount = By.XPath("//div[@class='space-y-6 text-sm']//div//button[@type='submit']");
        By BankDropdown = By.XPath("//div[contains(@class,'css-1gtu0rj-indicatorContainer')]//*[name()='svg']");
        By WemaBank = By.XPath("//body/div[9]/div[1]/div[1]/div[2]/div[1]/form[1]/div[1]/div[2]/div[2]/div[1]/input[1]");
        By Continue = By.XPath("//span[normalize-space()='Continue']");

        public void requestAccount(string email, string pass)
        {
            BrowserActions.Type(Email, email);
            BrowserActions.Type(Password, pass);
            BrowserActions.Click(LoginButton);
            BrowserActions.Click(RequestVirtualAccount);
            BrowserActions.Click(ContinueButton);
            BrowserActions.Click(RequestAccount);
            BrowserActions.Click(BankDropdown);
            BrowserActions.Click(WemaBank);
            BrowserActions.Click(Continue);

        }
    }
}

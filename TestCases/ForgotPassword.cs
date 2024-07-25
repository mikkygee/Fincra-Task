using FincraAssessment.PageObject;
using FincraAssessment.TestSetup;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FincraAssessment.TestCases
{
    public class ForgotPassword : BaseSetup
    {
        [Test]
        public void verifyClickForgotPassword()
        {
            ForgotPasswordPage myForgotPassword = new ForgotPasswordPage();
            myForgotPassword.ClickForgotPassword();
            Thread.Sleep(5000);
        }
        [Test]
        [TestCaseSource(nameof(GetTestData))]
        public void verifyForgotPasswordWithValidEmail(string email)
        {
            ForgotPasswordPage forgotpass = new ForgotPasswordPage();
            forgotpass.EnterValidEmail(email);
            Thread.Sleep(7000);
        }
        [TestCaseSource(nameof(GetTestData))]
        public void verifyReturnToLoginFromForgotPassword(string email)
        {
            ForgotPasswordPage return2login = new ForgotPasswordPage();
            return2login.ReturnToLogin();
            Thread.Sleep(7000);
        }
        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData(getDataReader().GetTestData("validEmail"));

        }

    }
}
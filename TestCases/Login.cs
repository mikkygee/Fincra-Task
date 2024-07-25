using FincraAssessment.PageObject;
using FincraAssessment.TestSetup;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FincraAssessment.TestCases

{
    public class Login: BaseSetup
    {
        [Test]
        [TestCaseSource(nameof(GetTestData))]
        public void verifyLoginWithValidEmailAndPassword(string email, string password)
        {
            LoginPage Login1 = new LoginPage();
            Login1.login(email, password);
            Thread.Sleep(10000);
        }

        [Test]
        [TestCaseSource(nameof(GetTestData))]
        public void verifyLoginWithInvalidPassword(string email, string password)
        {
            LoginPage Login2 = new LoginPage();
            Login2.login(email, password);  
            Thread.Sleep(5000);
        }
        [Test]
        public void verifyLoginWithEmptyEmail()
        {
            LoginPage Login3 = new LoginPage();
            Login3.login("", "");
            Thread.Sleep(3000);
        }

        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData(getDataReader().GetTestData("validEmail"), getDataReader().GetTestData("invalidPassword"));

        }
    }

}


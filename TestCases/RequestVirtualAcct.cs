using FincraAssessment.PageObject;
using FincraAssessment.TestSetup;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FincraAssessment.TestCases
{
    public class RequestVirtualAcct : BaseSetup
    {
        [Test]
        [TestCaseSource(nameof(GetTestData))]
        public void verifyRequestVirtualAccount(string email, string password)
        {
            RequestAccountNumber requestVA = new RequestAccountNumber();
            requestVA.requestAccount(email, password);
            Thread.Sleep(5000);
        }
        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData(getDataReader().GetTestData("validEmail"), getDataReader().GetTestData("validPassword"));

        }
    }
}


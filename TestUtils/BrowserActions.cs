﻿using FincraAssessment.TestSetup;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FincraAssessment.TestUtils
{
    public class BrowserActions:BaseSetup
    {
        public static void Type(By field, string value)
        {
            driver.FindElement(field).SendKeys(value);
        }
        public static void Click(By field)
        {
            driver.FindElement(field).Click();
        }
 
        public static void Refresh()
        {
            driver.Navigate().Refresh();
        }
    }
}

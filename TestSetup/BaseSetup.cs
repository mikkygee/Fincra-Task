
using FincraAssessment.TestUtils;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using System.Configuration;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace FincraAssessment.TestSetup
{
    public class BaseSetup
    {
        public static IWebDriver driver;

        [SetUp] 
        public void Setup()
        {
            string browser = ConfigurationManager.AppSettings["browser"];
            this.NewBrowser(browser);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Constants.DEFAULT_TIMEOUT);
            driver.Url = ConfigurationManager.AppSettings["URL"];

        }
        [TearDown]
        public void TearDown()
        {
            {
                driver.Quit();
            } 
        }
        public static JsonReader getDataReader()
        {

            return new JsonReader();
        }

        public void NewBrowser(string browserName)
        {
            switch (browserName.ToLower())
            {
                case "chrome":
                    ChromeOptions options = new ChromeOptions();
                    options.LeaveBrowserRunning = true;
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver(options);
                    driver.Manage().Window.Maximize();
                    break;
                case "firefox":
                    new DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                    break;
                case "safari":
                    driver = new SafariDriver();
                    driver.Manage().Window.Maximize();
                    break;
                default:
                    ChromeOptions options7 = new ChromeOptions();
                    options7.LeaveBrowserRunning = true;
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver(options7);
                    driver.Manage().Window.Maximize();
                    break;

            }
        }

    }
}

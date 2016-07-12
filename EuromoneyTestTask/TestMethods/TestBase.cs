using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace EuromoneyTestTask
{
    [TestFixture]
    class TestBase
    {
        protected IWebDriver driver;        
        protected string baseURL;
        protected NavigationMethods Navi;
        protected CheckMethods Check;

        [BeforeScenario]
        public void SetUp()
        {
            driver = new FirefoxDriver();
            baseURL = "http://www.euromoneyplc.com";
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            Navi = new NavigationMethods(driver);
            Check = new CheckMethods(driver);
        }

        [AfterScenario]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}

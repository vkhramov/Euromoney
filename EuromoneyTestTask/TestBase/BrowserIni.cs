using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace EuromoneyTestTask
{
    [Binding]
    public class BrowserIni
    {
        public static IWebDriver driver;
        public static string baseURL;
        
        [BeforeScenario]
        public void SetUp()
        {
            driver = new FirefoxDriver();
            baseURL = "http://www.euromoneyplc.com";            
        }

        [AfterScenario]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}

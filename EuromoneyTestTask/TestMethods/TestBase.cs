﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace EuromoneyTestTask
{
    [TestFixture]
    class TestBase
    {
        protected IWebDriver driver;
        private StringBuilder verificationErrors;
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

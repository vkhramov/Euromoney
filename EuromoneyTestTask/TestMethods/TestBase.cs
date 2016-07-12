using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace EuromoneyTestTask
{
    [TestFixture]
    class TestBase
    {
        public HomePage home = new HomePage();
        public LeftMenu leftMenu = new LeftMenu();
        public StoreMain storeMain = new StoreMain();
        public Book book = new Book();
        public ManagmentTeam managmentTeam = new ManagmentTeam();
        public ShoppingCart shopCart = new ShoppingCart();
           
        public IWebDriver driver = BrowserIni.driver;        
        public string baseURL = BrowserIni.baseURL;
               

        //[BeforeScenario]
        //public void SetUp()
        //{
        //    driver = new FirefoxDriver();
        //    baseURL = "http://www.euromoneyplc.com";
        //    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));                        
        //}

        //[AfterScenario]
        //public void Teardown()
        //{
        //    driver.Quit();
        //}
    }
}

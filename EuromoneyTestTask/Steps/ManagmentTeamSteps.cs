using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Firefox;

namespace EuromoneyTestTask
{
    [Binding]
    class ManagmentTeamSteps : TestBase
    {
        [Given(@"Set driver and URL")]
        public void GivenSetDriverAndURL()
        {
            driver = new FirefoxDriver();
            baseURL = "http://www.euromoneyplc.com";
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            Navi = new NavigationMethods(driver);
            Check = new CheckMethods(driver);
        }

        [Given(@"I am on the Home Page")]
        public void GivenIAmOnTheHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
        }
        
        [Given(@"Menu item opened")]
        public void GivenMenuItemOpened()
        {
            Navi.OpenMenu();
        }
        
        [Given(@"Who We Are submenu opened")]
        public void GivenWhoWeAreSubmenuOpened()
        {
            Navi.ClickWhoWeAre();
        }
        
        [When(@"I click on Managment team link")]
        public void WhenIClickOnManagmentTeamLink()
        {
            Navi.ClickManagmentTeam();
        }
        
        [Then(@"Managment team page opened")]
        public void ThenManagmentTeamPageOpened()
        {
            Check.CheckPage("http://www.euromoneyplc.com/who-we-are/management-team");
        }

        [When(@"Managment team page opened")]
        public void WhenManagmentTeamPageOpened()
        {
            driver.Navigate().GoToUrl(baseURL);
            Navi.OpenMenu();
            Navi.ClickWhoWeAre();
            Navi.ClickManagmentTeam();
        }

        
        [Then(@"The URL of the first image is present")]
        public void ThenTheURLOfTheFirstImageIsPresent()
        {
            Check.CheckImgURL();
        }
    }
}

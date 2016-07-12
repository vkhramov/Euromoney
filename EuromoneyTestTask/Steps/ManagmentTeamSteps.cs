using TechTalk.SpecFlow;

namespace EuromoneyTestTask
{
    [Binding]
    class ManagmentTeamSteps : TestBase
    {        

        [Given(@"I am on the Home Page")]
        public void GivenIAmOnTheHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
        }
        
        [Given(@"Menu item opened")]
        public void GivenMenuItemOpened()
        {
            home.OpenMenu();
        }
        
        [Given(@"Who We Are submenu opened")]
        public void GivenWhoWeAreSubmenuOpened()
        {
            leftMenu.ClickWhoWeAre();
        }
        
        [When(@"I click on Managment team link")]
        public void WhenIClickOnManagmentTeamLink()
        {
            leftMenu.ClickManagmentTeam();
        }
        
        [Then(@"Managment team page opened")]
        public void ThenManagmentTeamPageOpened()
        {
            leftMenu.CheckPage("http://www.euromoneyplc.com/who-we-are/management-team");
        }

        [When(@"Managment team page opened")]
        public void WhenManagmentTeamPageOpened()
        {
            driver.Navigate().GoToUrl(baseURL);
            home.OpenMenu();
            leftMenu.ClickWhoWeAre();
            leftMenu.ClickManagmentTeam();
        }

        
        [Then(@"The URL of the first image is present")]
        public void ThenTheURLOfTheFirstImageIsPresent()
        {
            managmentTeam.CheckImgURL();
        }
    }
}

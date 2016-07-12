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

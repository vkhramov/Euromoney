using TechTalk.SpecFlow;



namespace EuromoneyTestTask
{

    [Binding]
    class PurchaseBookOfMonthSteps : TestBase
    {

        [Given(@"I'am on Home Page")]
        public void GivenIAmOnHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
        }

       
        [When(@"I open menu item")]
        public void WhenIOpenMenuItem()
        {
            Navi.OpenMenu();
        }

        [Then(@"The Euromoney Store link displayed correctly on the menu item")]
        public void ThenTheEuromoneyStoreLinkDisplayedCorrectlyOnTheMenuItem()
        {
            Check.CheckStoreLink();
        }

        [Given(@"Menu item opened on the home page")]
        public void GivenMenuItemOpenedOnTheHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
            Navi.OpenMenu();
        }

        [When(@"I press on Store link")]
        public void WhenIPressOnStoreLink()
        {
            Navi.ClickOnStoreLink();
        }

        [Then(@"It navigates to the online store")]
        public void ThenItNavigatesToTheOnlineStore()
        {
            Navi.SwithToStoreWindow();
            Check.CheckPage("http://store.euromoneyplc.com/");
        }
        
        [Given(@"I am on Store page")]
        public void GivenIAmOnStorePage()
        {
            driver.Navigate().GoToUrl(baseURL);
            Navi.OpenMenu();
            Navi.ClickOnStoreLink();
            Navi.SwithToStoreWindow();
            Navi.ClosePopUp();
        }

        [When(@"I press more details link on the book of month")]
        public void WhenIPressMoreDetailsLinkOnTheBookOfMonth()
        {
            Navi.ClickOnMoreDetails();
        }

        [Then(@"it navigates to the details page")]
        public void ThenItNavigatesToTheDetailsPage()
        {
            //If "Add to cart" button presented wa are on "details" page.
            Navi.ClickOnAddToChart();
        }
        
        [Given(@"I am on Book of month details page")]
        public void GivenIAmOnBookOfMonthDetailsPage()
        {
            driver.Navigate().GoToUrl(baseURL);
            Navi.OpenMenu();
            Navi.ClickOnStoreLink();
            Navi.SwithToStoreWindow();
            Navi.ClosePopUp();
            Navi.ClickOnMoreDetails();
        }

        [When(@"I click Add to cart")]
        public void WhenIClick()
        {
            Navi.ClickOnAddToChart();
        }

        [Then(@"Book of the month is added to the shopping cart")]
        public void ThenBookOfTheMonthIsAddedToTheShoppingCart()
        {
            Check.CheckIfBookAdded();
        }
        
        [Then(@"The price of the book is displayed in GBP")]
        public void ThenThePriceOfTheBookIsDisplayedInGBP()
        {
            Check.CheckPriceCurency();
        }
    }
}

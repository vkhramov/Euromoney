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
            home.OpenMenu();
        }

        [Then(@"The Euromoney Store link displayed correctly on the menu item")]
        public void ThenTheEuromoneyStoreLinkDisplayedCorrectlyOnTheMenuItem()
        {
            leftMenu.CheckStoreLink();
        }

        [Given(@"Menu item opened on the home page")]
        public void GivenMenuItemOpenedOnTheHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
            home.OpenMenu();
        }

        [When(@"I press on Store link")]
        public void WhenIPressOnStoreLink()
        {
            leftMenu.ClickOnStoreLink();
        }

        [Then(@"It navigates to the online store")]
        public void ThenItNavigatesToTheOnlineStore()
        {
            storeMain.SwithToStoreWindow();
            storeMain.CheckPage("http://store.euromoneyplc.com/");
        }
        
        [Given(@"I am on Store page")]
        public void GivenIAmOnStorePage()
        {
            driver.Navigate().GoToUrl(baseURL);
            home.OpenMenu();
            leftMenu.ClickOnStoreLink();
            storeMain.SwithToStoreWindow();
            storeMain.ClosePopUp();
        }

        [When(@"I press more details link on the book of month")]
        public void WhenIPressMoreDetailsLinkOnTheBookOfMonth()
        {
            storeMain.ClickOnMoreDetails();
        }

        [Then(@"it navigates to the details page")]
        public void ThenItNavigatesToTheDetailsPage()
        {
            //If "Add to cart" button presented wa are on "details" page.
            book.ClickOnAddToChart();
        }
        
        [Given(@"I am on Book of month details page")]
        public void GivenIAmOnBookOfMonthDetailsPage()
        {
            driver.Navigate().GoToUrl(baseURL);
            home.OpenMenu();
            leftMenu.ClickOnStoreLink();
            storeMain.SwithToStoreWindow();
            storeMain.ClosePopUp();
            storeMain.ClickOnMoreDetails();
        }

        [When(@"I click Add to cart")]
        public void WhenIClick()
        {
            book.ClickOnAddToChart();
        }

        [Then(@"Book of the month is added to the shopping cart")]
        public void ThenBookOfTheMonthIsAddedToTheShoppingCart()
        {
            shopCart.CheckIfBookAdded();
        }
        
        [Then(@"The price of the book is displayed in GBP")]
        public void ThenThePriceOfTheBookIsDisplayedInGBP()
        {
            shopCart.CheckPriceCurency();
        }
    }
}

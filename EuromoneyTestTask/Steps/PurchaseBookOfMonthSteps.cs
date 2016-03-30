using System;
using TechTalk.SpecFlow;

namespace EuromoneyTestTask
{
    [Binding]
    public class PurchaseBookOfMonthSteps
    {
        [Given(@"Menu item opened on the home page")]
        public void GivenMenuItemOpenedOnTheHomePage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I am on Store page")]
        public void GivenIAmOnStorePage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I am on Book of month details page")]
        public void GivenIAmOnBookOfMonthDetailsPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I open menu item")]
        public void WhenIOpenMenuItem()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press on Store link")]
        public void WhenIPressOnStoreLink()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press ""(.*)"" link on the book of month")]
        public void WhenIPressLinkOnTheBookOfMonth(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click ""(.*)""")]
        public void WhenIClick(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I add book of month to cart")]
        public void WhenIAddBookOfMonthToCart()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The Euromoney Store link displayed correctly on the menu item")]
        public void ThenTheEuromoneyStoreLinkDisplayedCorrectlyOnTheMenuItem()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"It navigates to the online store")]
        public void ThenItNavigatesToTheOnlineStore()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"it navigates to the details page")]
        public void ThenItNavigatesToTheDetailsPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Book of the month is added to the shopping cart")]
        public void ThenBookOfTheMonthIsAddedToTheShoppingCart()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The price of the book is displayed in GBP")]
        public void ThenThePriceOfTheBookIsDisplayedInGBP()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

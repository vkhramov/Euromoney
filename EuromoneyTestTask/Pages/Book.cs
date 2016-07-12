using OpenQA.Selenium;

namespace EuromoneyTestTask
{
    public class Book : BasePage
    {
        public By addToCart = By.XPath("//input[@value='Add to cart']");

        public void ClickOnAddToChart()
        {
            ClickOn(addToCart, "Add to cart button");
        }
        
    }
}

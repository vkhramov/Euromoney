using OpenQA.Selenium;

namespace EuromoneyTestTask
{
    class Book
    {
        public By addToCart;

        public Book()
        {
            addToCart = By.XPath("//input[@value='Add to cart']");
        }
    }
}

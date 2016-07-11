using OpenQA.Selenium;

namespace EuromoneyTestTask
{
    class HomePage
    {       
        public By menuItem;

        public HomePage()
        {            
            menuItem = By.CssSelector("span.icon-nav");
        }
    }
}

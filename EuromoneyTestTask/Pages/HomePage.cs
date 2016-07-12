using OpenQA.Selenium;

namespace EuromoneyTestTask
{
    public class HomePage : BasePage
    {       

        public By menuItem = By.CssSelector("span.icon-nav");

        public void OpenMenu()
        {
            ClickOn(menuItem, "Menu button");
        }

    }
}

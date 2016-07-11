using OpenQA.Selenium;

namespace EuromoneyTestTask
{
    class StoreMain
    {
        public By viewMoreDetailButton;

        public StoreMain()
        {
            viewMoreDetailButton = By.XPath("(//input[@value='View more details'])[1]");
        }
    }
}

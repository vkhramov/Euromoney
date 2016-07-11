using OpenQA.Selenium;

namespace EuromoneyTestTask
{
    class LeftMenu
    {
        public By whoWeAreLink;
        public By managmentTeamLink;
        public By storeLink;

        public LeftMenu()
        {
            whoWeAreLink = By.XPath("//a[text()='Who we are']");
            managmentTeamLink = By.XPath("//a[contains(text(),'Management team')]");
            storeLink = By.XPath("//a[contains(text(), 'Euromoney Store')]");
        }

    }
}

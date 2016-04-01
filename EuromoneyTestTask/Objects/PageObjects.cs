using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace EuromoneyTestTask
{
    class PageObjects
    {
        IWebDriver driver;
        public By whoWeAreLink;
        public By managmentTeamLink;
        public By viewMoreDetailButton;
        public By storeLink;
        public By addToCart;

        public PageObjects(IWebDriver driver)
        {
            this.driver = driver;
            whoWeAreLink = By.XPath("//a[text()='Who we are']");
            managmentTeamLink = By.XPath("//a[contains(text(),'Management team')]");
            viewMoreDetailButton = By.XPath("(//input[@value='View more details'])[1]");
            storeLink = By.XPath("//a[contains(text(), 'Euromoney Store')]");
            addToCart = By.XPath("//input[@value='Add to cart']");
        }
    }
}

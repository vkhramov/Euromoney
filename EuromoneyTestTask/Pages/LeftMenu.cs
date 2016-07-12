using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;

namespace EuromoneyTestTask
{
    public class LeftMenu : BasePage
    {
        public By whoWeAreLink = By.XPath("//a[text()='Who we are']");
        public By managmentTeamLink = By.XPath("//a[contains(text(),'Management team')]");
        public By storeLink = By.XPath("//a[contains(text(), 'Euromoney Store')]");

        public void ClickWhoWeAre()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(whoWeAreLink));
            ClickOn(whoWeAreLink, "WHO WE ARE button");
        }

        public void ClickOnStoreLink()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(".//*[@id='menu']/li[6]/a")));
            wait.Until(ExpectedConditions.ElementToBeClickable(storeLink));
            ClickOn(storeLink, "Store link");
        }

        public void ClickManagmentTeam()
        {
            ClickOn(managmentTeamLink, "Management Team button");
        }

        public void CheckStoreLink()
        {
            if (driver.FindElement(By.XPath(".//*[@id='menu']/li[6]/a")).Text != "EUROMONEY STORE")
            {
                throw new Exception("Wrong Element: ");
            }
        }



    }
}

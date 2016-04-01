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
    class NavigationMethods
    {
        IWebDriver driver;
        PageObjects page;

        public NavigationMethods(IWebDriver driver)
        {
            this.driver = driver;
            page = new PageObjects(this.driver);            
        }

       

        public void ClickOn(By locator, string name)
        {
            if (IsElementPresent(locator))
            {
                driver.FindElement(locator).Click();
            }
            else
            {
                throw new Exception(name + " not found");
            }
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void ClickManagmentTeam()
        {
            ClickOn(page.managmentTeamLink, "Management Team button");
        }

        public void ClickOnAddToChart()
        {
            ClickOn(page.addToCart, "Add to cart button");
        }

        public void ClickOnMoreDetails()
        {
            //wait while mask disappear
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(".//*[@id='exposeMask']")));
            ClickOn(page.viewMoreDetailButton, "View more details button ");
        }

        public void ClickOnStoreLink()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(".//*[@id='menu']/li[6]/a")));
            ClickOn(page.storeLink, "Store link");
        }

        public void ClickWhoWeAre()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(page.whoWeAreLink));
            ClickOn(page.whoWeAreLink, "WHO WE ARE button");
        }

        public void OpenMenu()
        {
            ClickOn(By.CssSelector("span.icon-nav"), "Menu button");
        }

        public void ClosePopUp()
        {
            //Close pop-up if it appear.
            try
            {
                driver.FindElement(By.CssSelector("a.closePopup")).Click();
            }
            catch (NoSuchElementException) { }
        }

        public void SwithToStoreWindow()
        {
            foreach (var winHandle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(winHandle);
            }
        }
    }
}

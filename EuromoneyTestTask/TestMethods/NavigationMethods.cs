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

        public NavigationMethods(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void ClickManagmentTeam()
        {
            ClickOn(By.XPath(".//*[@id='7F0853DA9D724593BF11788E77D841BD-collapse']/li[4]/a"), "Management Team button");
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

        public void ClickOnAddToChart()
        {
            ClickOn(By.CssSelector("td.btn_addtocart > input.btnSubmit"), "Add to cart button");
        }

        public void ClickOnMoreDetails()
        {
            //wait while mask disappear
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(".//*[@id='exposeMask']")));
            ClickOn(By.XPath("html/body/table/tbody/tr[2]/td[2]/div/table/tbody/tr[3]/td[1]/table/tbody/tr[2]/td/input"), "View more details button "); //TODO optimize XPath!
        }

        public void ClickOnStoreLink()
        {
            driver.FindElement(By.XPath(".//*[@id='menu']/li[6]/a")).Click();
            //driver.FindElement(By.XPath(".//*[@id='menu']/li[6]/a")).Click();
        }

        public void ClickWhoWeAre()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(".//*[@id='7F0853DA9D724593BF11788E77D841BD']/a")));
            ClickOn(By.XPath(".//*[@id='7F0853DA9D724593BF11788E77D841BD']/a"), "WHO WE ARE button");
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

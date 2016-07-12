using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace EuromoneyTestTask
{
    public class BasePage
    {

        public IWebDriver driver = BrowserIni.driver;

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

        public void CheckPage(string refURL)
        {
            string pageURL = driver.Url;
            Assert.AreEqual(refURL, pageURL);
        }
    }
}

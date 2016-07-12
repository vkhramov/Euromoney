using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;

namespace EuromoneyTestTask
{
    public class StoreMain : BasePage
    {
        public By viewMoreDetailButton = By.XPath("(//input[@value='View more details'])[1]");

        public void ClickOnMoreDetails()
        {
            //wait while mask disappear
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(".//*[@id='exposeMask']")));

            ClickOn(viewMoreDetailButton, "View more details button ");
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

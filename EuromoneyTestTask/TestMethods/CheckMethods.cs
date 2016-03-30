using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace EuromoneyTestTask
{
    class CheckMethods
    {
        IWebDriver driver;

        public CheckMethods(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void CheckStoreLink()
        {
            if (driver.FindElement(By.XPath(".//*[@id='menu']/li[6]/a")).Text != "EUROMONEY STORE")
            {
                throw new Exception("Wrong Element: ");
            }
        }

        public void CheckPage(string refURL)
        {
            string pageURL = driver.Url;
            Assert.AreEqual(refURL, pageURL);
        }

        public void CheckIfBookAdded()
        {
            string quantity = driver.FindElement(By.XPath("html/body/table/tbody/tr[2]/td[2]/div/table[1]/tbody/tr/td/div/form/table/tbody/tr[2]/td[2]/input")).GetAttribute("value");
            Console.WriteLine("Quantity: " + quantity);
            Assert.AreEqual(quantity, "1");
        }

        public void CheckPriceCurency()
        {
            //check if currency is GBP
            string priceCurrency = driver.FindElement(By.XPath(".//*[@id='cID']/option[1]")).GetAttribute("selected");
            Assert.AreEqual("true", priceCurrency, "currancy is GPB: ");
        }

        public void CheckImgURL()
        {
            string firstImageSrc = null;
            firstImageSrc = driver.FindElement(By.XPath("html/body/section/div[2]/div/div/div/div/div/img")).GetAttribute("src"); //get first image URL
            Assert.AreNotEqual(firstImageSrc, null, "First image URL "); //check if URL presented
        }
    }
}

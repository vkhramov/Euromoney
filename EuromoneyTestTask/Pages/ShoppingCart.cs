using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace EuromoneyTestTask
{
    public class ShoppingCart : BasePage
    {
        public void CheckIfBookAdded()
        {
            string quantity = driver.FindElement(By.XPath(".//*[@class='tbl03 tbl03_roundbg']//input[@type='text']")).GetAttribute("value");
            Console.WriteLine("Quantity: " + quantity);
            Assert.AreEqual(quantity, "1");
        }

        public void CheckPriceCurency()
        {
            //check if currency is GBP
            string priceCurrency = driver.FindElement(By.XPath(".//*[@id='cID']/option[1]")).GetAttribute("selected");
            Assert.AreEqual("true", priceCurrency, "currency is GPB: ");
        }
    }
}

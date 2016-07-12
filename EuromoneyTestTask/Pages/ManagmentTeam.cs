using NUnit.Framework;
using OpenQA.Selenium;

namespace EuromoneyTestTask
{    
    public class ManagmentTeam : BasePage
    {
        public void CheckImgURL()
        {
            string firstImageSrc = null;
            firstImageSrc = driver.FindElement(By.XPath("//section/div[2]//img")).GetAttribute("src"); //get first image URL
            Assert.AreNotEqual(firstImageSrc, null, "First image URL "); //check if URL presented
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace EuromoneyTestTask
{
    public class HomePage : BasePage
    {       

        public By menuItem = By.CssSelector("span.icon-nav");

        public void OpenMenu()
        {
            ClickOn(menuItem, "Menu button");
        }

    }
}

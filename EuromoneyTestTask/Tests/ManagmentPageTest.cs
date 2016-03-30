using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;


namespace EuromoneyTestTask
{
    [TestFixture]
    class EuromoneyTest : TestBase
    {
        private string managmentPageRefURL = "http://www.euromoneyplc.com/who-we-are/management-team";

        [Test]
        public void ManagmentTeamPageTest()
        {
            Navi.OpenMenu();
            Navi.ClickWhoWeAre();
            Navi.ClickManagmentTeam();
            Check.CheckPage(managmentPageRefURL);
            Check.CheckImgURL();
        }
    }
}

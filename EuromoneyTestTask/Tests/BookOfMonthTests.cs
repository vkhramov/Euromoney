using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace EuromoneyTestTask
{
    [TestFixture]
    class BookOfMonthTests : TestBase
    {
        
        private string storeRefURL = "http://store.euromoneyplc.com/";

        [Test]
        public void BookOfMonthTest()
        {
            Navi.OpenMenu();
            Check.CheckStoreLink();
            Navi.ClickOnStoreLink();
            Navi.SwithToStoreWindow();
            Check.CheckPage(storeRefURL);
            Navi.ClosePopUp();
            Navi.ClickOnMoreDetails();
            Navi.ClickOnAddToChart(); //If "Add to cart" button presented wa are on "details" page.
            Check.CheckIfBookAdded();
            Check.CheckPriceCurency();
        }

        

        

        

        

       

        

        

        

       

        
    }
}

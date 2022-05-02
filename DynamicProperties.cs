using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using System.Net;
using System.Collections.ObjectModel;
using DemoQASite;

namespace ElementTesting
{
     class DynamicProperties : Selenium_Base
    {
        public void Dynamic_Properties(IWebDriver Driver)
        {
            open("https://demoqa.com/elements");
            wait(500);

            scrollPage(0, 500);
            wait(500);

            click(FindID("item-8"));
            wait(7000);

            close();
            wait(2000);
        }
    }
}

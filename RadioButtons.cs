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
    class RadioButtons : Selenium_Base
    {
        public void RadioButton(IWebDriver Driver)
        {
            open("https://demoqa.com/elements");
            wait(500);

            click(FindID("item-2"));
            wait(2000);

            click(FindXPath("//label[@for='yesRadio']"));
            wait(2000);

            click(FindXPath("//label[@for='impressiveRadio']"));
            wait(2000);

            close();
            wait(2000);
        }
    }
}

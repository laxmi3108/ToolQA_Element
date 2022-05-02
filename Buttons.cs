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
     class Buttons : Selenium_Base
    {
        public void ButtonsTesting(IWebDriver Driver)
        {
            open("https://demoqa.com/elements");
            wait(500);

            scrollPage(0, 300);
            wait(500);

            click(FindID("item-4"));
            wait(2000);

            click(FindXPath("//*[text()='Click Me']"));
            wait(2000);
            doubleClick(FindID("doubleClickBtn"));
            wait(2000);
            contextClick(FindID("rightClickBtn"));
            wait(2000);

            close();
            wait(2000);

        }
     }
}

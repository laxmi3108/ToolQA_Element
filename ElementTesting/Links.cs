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
    class Links : Selenium_Base
    {
        public void SimpleLink(IWebDriver Driver)
        {
            open("https://demoqa.com/elements");
            wait(500);

            scrollPage(0, 500);
            wait(500);

            click(FindID("item-5"));
            wait(2000);

            click(FindID("simpleLink"));
            wait(2000);
            switchToWindow(1);
            close();
            wait(2000);
            switchToWindow(0);
        }

        public void DynamicLink(IWebDriver Driver)
        {
            click(FindID("dynamicLink"));
            wait(2000);

            switchToWindow(1);
            close();
            wait(2000);
            switchToWindow(0);
            scrollPage(0, 400);
            wait(2000);
        }

        public void OtherLink(IWebDriver Driver)
        {
            click(FindID("created"));
            wait(2000);
            click(FindID("no-content"));
            wait(2000);
            click(FindID("moved"));
            wait(2000);
            click(FindID("bad-request"));
            wait(2000);
            click(FindID("unauthorized"));
            wait(2000);
            click(FindID("forbidden"));
            wait(2000);
            click(FindID("invalid-url"));
            wait(2000);

            close();
            wait(2000);
        }
    }
}

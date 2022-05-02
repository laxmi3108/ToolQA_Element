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
    class TextBox : Selenium_Base
    {
        public void TextBoxTesting(IWebDriver Driver)
        {
            open("https://demoqa.com/elements");
            wait(500);

            click(FindID("item-0"));
            wait(2000);

            string name = "Laxmi Gorai";
            string email = "laxmi31@gmail.com";
            string cadd = "kolkata";
            string padd = "Durgapur";

            sendKeys(FindID("userName"), name);
            wait(2000);

            sendKeys(FindID("userEmail"), email);
            wait(2000);

            sendKeys(FindID("currentAddress"), cadd);
            wait(2000);

            sendKeys(FindID("permanentAddress"), padd);
            wait(2000);

            scrollPage(0, 200);

            click(FindID("submit"));
            wait(2000);

            close();
            wait(2000);

        }
    }
}

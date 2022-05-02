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
    class UploadDownload : Selenium_Base
    {
        public void Upload_Download(IWebDriver Driver)
        {
            open("https://demoqa.com/elements");
            wait(500);

            scrollPage(0, 500);
            wait(500);

            click(FindID("item-7"));
            wait(2000);

            click(FindID("downloadButton"));
            wait(2000);

            sendKeys(FindID("uploadFile"), @"C:\picture\crp3 (2).jpeg");
            wait(2000);

            close();
            wait(2000);
        }
    }
}

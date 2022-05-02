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
    class BrokenLinksImg : Selenium_Base
    {
        public void ClickBrokenLinksImg(IWebDriver Driver)
        {
            open("https://demoqa.com/elements");
            wait(500);

            scrollPage(0, 500);
            wait(500);

            click(FindID("item-6"));
            wait(2000);
        }
        public void ValidateImage(IWebDriver Driver)
        {
            ReadOnlyCollection<IWebElement> elements = FindAllBy(By.TagName("img"));

            IWebElement validImage = elements[2];
            IWebElement brokenImage = elements[3];

            Console.WriteLine("Valid Image Response : " + testForValidImage(getAttribute(validImage, "src")));
            Console.WriteLine("Broken Image Response : " + testForValidLink(getAttribute(brokenImage, "src")));

            wait(500);
        }

        public void ValidateHttpLink(IWebDriver Driver)
        {
            Console.WriteLine("Valid Link Response : " + testForValidLink(getAttribute(FindXPath("//a[text()='Click Here for Valid Link']"), "href")));
            Console.WriteLine("Broken Link Response : " + testForValidLink(getAttribute(FindXPath("//a[text()='Click Here for Broken Link']"), "href")));

            wait(3000);

            close();
            wait(2000);
        }
    }
}

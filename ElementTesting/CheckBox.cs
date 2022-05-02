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
    class CheckBox : Selenium_Base
    {
        public void ExpandBtn(IWebDriver Driver)
        {
            click(FindClass("rct-option-expand-all"));
        }

        public void CollapseBtn(IWebDriver Driver)
        {
            click(FindClass("rct-option-collapse-all"));
        }

        public void CheckBoxTesting(IWebDriver Driver)
        {
            open("https://demoqa.com/elements");
            wait(500);

            click(FindID("item-1"));
            wait(2000);

            ExpandBtn(Driver);
            wait(2000);
            CollapseBtn(Driver);
            wait(2000);

            click(FindXPath("//*[text()='Home']"));
            wait(2000);
            ExpandBtn(Driver);
            wait(2000);

            click(FindXPath("//*[text()='Desktop']"));
            wait(2000);
            ExpandBtn(Driver);
            wait(2000);

            click(FindXPath("//*[text()='Notes']"));
            wait(2000);

            click(FindXPath("//*[text()='Commands']"));
            wait(2000);

            click(FindAllBy(By.XPath("//button[@title='Toggle']"))[1]);
            wait(2000);

            click(FindXPath("//*[text()='Angular']"));
            wait(2000);

            click(FindXPath("//*[text()='Angular']"));
            wait(2000);

            click(FindAllBy(By.XPath("//button[@title='Toggle']"))[3]);
            wait(2000);

            click(FindAllBy(By.XPath("//button[@title='Toggle']"))[4]);
            wait(2000);

            ExpandBtn(Driver);
            wait(2000);
            scrollPage(0, 300);
            wait(2000);

            click(FindXPath("//*[text()='Private']"));
            wait(2000);

            click(FindAllBy(By.XPath("//button[@title='Toggle']"))[4]);
            wait(2000);

            CollapseBtn(Driver);
            wait(2000);

            click(FindXPath("//*[text()='Home']"));
            wait(2000);

            close();
            wait(2000);
        }
    }
}

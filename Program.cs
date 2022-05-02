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
    internal class Program : Selenium_Base
    {
        public static void Main(string[] args)
        {
            IWebDriver Driver=null;

            TextBox tb = new TextBox();

            tb.TextBoxTesting(Driver);

            CheckBox cb = new CheckBox();
            cb.CheckBoxTesting(Driver);

            RadioButtons radioButtons = new RadioButtons();
            radioButtons.RadioButton(Driver);

            WebTables webTables = new WebTables();
            webTables.clickOnWebTableOption(Driver);

            webTables.Add(Driver);

            webTables.Edit(Driver);

            webTables.Delete(Driver);

            webTables.Search(Driver);

            Buttons buttons = new Buttons();

            buttons.ButtonsTesting(Driver);

            Links links = new Links();

            links.SimpleLink(Driver);

            links.DynamicLink(Driver);

            links.OtherLink(Driver);


            BrokenLinksImg brokenLinksImg = new BrokenLinksImg();

            brokenLinksImg.ClickBrokenLinksImg(Driver);

            brokenLinksImg.ValidateImage(Driver);

            brokenLinksImg.ValidateHttpLink(Driver);

            UploadDownload uploadDownload = new UploadDownload();

            uploadDownload.Upload_Download(Driver);

            DynamicProperties dynamicProperties = new DynamicProperties();

            dynamicProperties.Dynamic_Properties(Driver);

        }
    }
}

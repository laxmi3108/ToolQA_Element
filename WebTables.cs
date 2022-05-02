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
    class WebTables : Selenium_Base
    {
        public void clickOnWebTableOption(IWebDriver Driver)
        {
            open("https://demoqa.com/elements");
            wait(500);

            click(FindID("item-3"));
            wait(2000);
        }
        public void Add(IWebDriver Driver)
        {
            
            string[] fname = { "Laxmi", "Mina", "Suravi", "Riya", "Piu", "Shreya", "Piya", "Kiya" };
            string[] lname = { "Gorai", "Shaw", "Singh", "Mondal", "Shaoo", "Kar", "Karmakar", "Chell" };
            string[] emailid = { "laxmi123@gmail.com", "mina123@gmail.com", "suravi123@gmail.com", "riya123@gmail.com", "piu123@gmail.com", "shreya123@gmail.com", "piya123@gmail.com", "kiya123@gmail.com" };
            string[] age = { "22","20","18","25","29","24","32","31" };
            string[] salary = { "400000","20000","5000","40000","355000","57000","29000","450000" };
            string[] dept = { "testing", "CSE", "IT", "ECE", "ME", "TEST", "DEV", "CSE/IT" };


            for (int i = 0; i < fname.Length; i++)
            {
                click(FindXPath("//*[text()='Add']"));
                wait(2000);

                sendKeys(FindID("firstName"), fname[i]);
                wait(2000);
                sendKeys(FindID("lastName"), lname[i]);
                wait(2000);
                sendKeys(FindID("userEmail"), emailid[i]);
                wait(2000);
                sendKeys(FindID("age"), age[i]);
                wait(2000);
                sendKeys(FindID("salary"), salary[i]);
                wait(2000);
                sendKeys(FindID("department"), dept[i]);
                wait(2000);
                //Driver.FindElement(By.Id("department")).SendKeys(Keys.Enter);
                click(FindID("submit"));
                wait(2000);
            }
        }
        public void Edit(IWebDriver Driver)
        {
            string editfname = "Mina";
            click(FindID("edit-record-1"));
            wait(2000);
            clearAndSendKeys(FindID("firstName"), editfname);
            wait(2000);
            click(FindID("submit"));
            wait(2000);
        }
        public void Delete(IWebDriver Driver)
        {
            click(FindID("delete-record-1"));
            wait(2000);
        }
        public void Search(IWebDriver Driver)
        {
            string search = "Laxmi";
            sendKeys(FindID("searchBox"), search);
            wait(2000);
            click(FindClass("input-group-text"));
            wait(2000);
            clear(FindID("searchBox"));
            wait(2000);

            close();
            wait(2000);
        }
    }
}

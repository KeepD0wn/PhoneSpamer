using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PhoneSpamer.Sites
{
    class Uytstroi33 : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://uytstroi33.ru/");
            ISite.browser.Manage().Window.Maximize();
            IWebElement btn = ISite.browser.FindElement(By.ClassName("button_pust"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.Id("name_zamer")).SendKeys(ISite.Name); 
            ISite.browser.FindElement(By.Id("number_zamer")).SendKeys(ISite.PhoneNumber);
            IWebElement btnSend = ISite.browser.FindElement(By.ClassName("button"));
            btnSend.Click();
        }
    }
}

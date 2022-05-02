using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SmsSpamer.Sites
{
    class GrowFood : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://growfood.pro/login");
            ISite.browser.Manage().Window.Maximize();           

            ISite.browser.FindElement(By.XPath("//*[@id='phone']")).SendKeys(ISite.PhoneNumberWithout7);

            IWebElement btn = ISite.browser.FindElement(By.XPath("//*[@id='login-block']/button"));
            btn.Click();
        }

    }
}
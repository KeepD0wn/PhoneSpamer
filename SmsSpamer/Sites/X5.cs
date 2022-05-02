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
    class X5 : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://id.x5.ru/");
            ISite.browser.Manage().Window.Maximize();

            ISite.browser.FindElement(By.XPath("//*[@id='phone']")).SendKeys(ISite.PhoneNumberWithout7);

            IWebElement btn = ISite.browser.FindElement(By.XPath("//*[@id='Capa_1']"));
            btn.Click();
        }

    }
}
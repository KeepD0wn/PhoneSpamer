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
    class Ikea : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://www.ikea.com/ru/ru/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn0 = ISite.browser.FindElement(By.XPath("//*[@id='hnf-header-profile']/a/span"));
            btn0.Click();
            Thread.Sleep(1000);

            IWebElement btn1 = ISite.browser.FindElement(By.XPath("//*[@id='loyalty-modal-content']/div/div/div[1]/a/span"));
            btn1.Click();
            Thread.Sleep(3000);

            ISite.browser.FindElement(By.XPath("//*[@id='username']")).SendKeys(ISite.PhoneNumber);

            IWebElement btn = ISite.browser.FindElement(By.XPath("//*[@id='root']/div/div[3]/div[1]/form/a[1]"));
            btn.Click();
        }

    }
}
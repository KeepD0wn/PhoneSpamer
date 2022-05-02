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
    class Wildberries : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://www.wildberries.ru/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn0 = ISite.browser.FindElement(By.XPath("//*[@id='basketContent']/div[2]/a"));
            btn0.Click();
            Thread.Sleep(1000);

            ISite.browser.FindElement(By.XPath("//*[@id='spaAuthForm']/div/div[1]/div/div[2]/input")).SendKeys(ISite.PhoneNumberWithout7);

            IWebElement btn = ISite.browser.FindElement(By.XPath("//*[@id='requestCode']"));
            btn.Click();
        }

    }
}
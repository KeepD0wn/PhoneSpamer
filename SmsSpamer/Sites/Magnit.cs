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
    class Magnit : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://new.moy.magnit.ru");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn0 = ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[4]/a"));
            btn0.Click();
            Thread.Sleep(1000);

            ISite.browser.FindElement(By.XPath("//*[@id='phone']")).SendKeys(ISite.PhoneNumberWithout7);

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div[3]/div/div[2]/form/div[2]/button"));
            btn.Click();
        }

    }
}
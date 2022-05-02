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
    class IGoods : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://igooods.globus.ru/select_address");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("//*[@id='root']/div[1]/div/header/div[5]/button/div/span/div"));
            btn.Click();
            Thread.Sleep(1000);

            ISite.browser.FindElement(By.XPath("//*[@id='portal-root']/div/div/div/div/div/div/div[2]/div/input")).SendKeys(ISite.PhoneNumberWithout7);
        }

    }
}

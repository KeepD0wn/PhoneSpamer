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
    class Macdonalds : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://mcdonalds.ru/menu/delivery");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn0 = ISite.browser.FindElement(By.XPath("/html/body/div[1]/div/div/header/div/div[1]/div/div[2]/div[1]/div[2]/span"));
            btn0.Click();
            Thread.Sleep(1000);

            ISite.browser.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div[2]/div/div[1]/input")).SendKeys(ISite.PhoneNumberWithout7);

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div[2]/div/div[2]/button/span"));
            btn.Click();
        }

    }
}
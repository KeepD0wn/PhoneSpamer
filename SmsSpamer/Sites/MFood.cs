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
    class MFood : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://m-food.ru/");
            ISite.browser.Manage().Window.Maximize();

            Thread.Sleep(1000);
            IWebElement btn9 = ISite.browser.FindElement(By.XPath("/html/body/div/div/div/section[1]/header/div[1]/div/div/div[1]/div/div/div/div/div[2]/button[2]"));
            btn9.Click();

            IWebElement btn0 = ISite.browser.FindElement(By.XPath("/html/body/div/div/div/section[1]/header/div[1]/div/div/a/span"));
            btn0.Click();
            Thread.Sleep(2000);

            ISite.browser.FindElement(By.XPath("/html/body/div/div/div/span[1]/div[2]/div[2]/div/div/div[2]/div/div[1]/div/input")).SendKeys(ISite.PhoneNumberWithout7);

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div/div/div/span[1]/div[2]/div[2]/div/div/div[2]/div/div[2]/button"));
            btn.Click();
        }

    }
}
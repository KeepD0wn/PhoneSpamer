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
    class HH : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://vladimir.hh.ru/account/login?backurl=%2F");
            ISite.browser.Manage().Window.Maximize();

            ISite.browser.FindElement(By.XPath("//*[@id='HH-React-Root']/div/div/div[1]/div/div/div/div/div/div[1]/div[1]/div[1]/div[2]/div/div/form/div[1]/input")).SendKeys(ISite.PhoneNumberWithout7);
           
            IWebElement btn = ISite.browser.FindElement(By.XPath("//*[@id='HH-React-Root']/div/div/div[1]/div/div/div/div/div/div[1]/div[1]/div[1]/div[2]/div/div/form/div[4]/button[1]/span"));
            btn.Click();
        }

    }
}
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PhoneSpamer.Sites
{
    class Samson : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://samsonstroy.ru/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("//*[@id='WJC141']/a"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("//*[@id='WJCForm141_name']")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("//*[@id='WJCForm141_phone']")).SendKeys(ISite.PhoneNumberWithout7); //Нахожу строку поиска Google и вписываю "Selenium"

            IWebElement btnSend = ISite.browser.FindElement(By.XPath("//*[@id='WJCForm141']/div/div/form/div[3]/button"));
            btnSend.Click();
        }
    }
}
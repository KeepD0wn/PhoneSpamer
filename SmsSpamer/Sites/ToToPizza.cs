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
    class ToToPizza : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://totopizza.ru/");
            ISite.browser.Manage().Window.Maximize();

            try
            {
                Thread.Sleep(2000);
                IWebElement btn0 = ISite.browser.FindElement(By.XPath("//*[@id='closemodalcity']"));
                btn0.Click();
            }
            catch { }            

            IWebElement btn1 = ISite.browser.FindElement(By.XPath("//*[@id='wrapper']/header/div[2]/div/div/div[3]/a"));
            btn1.Click();
            Thread.Sleep(2000);

            ISite.browser.FindElement(By.XPath("//*[@id='phoneauth']")).SendKeys(ISite.PhoneNumberWithout7);

            IWebElement btn = ISite.browser.FindElement(By.XPath("//*[@id='authmodalsms']/div/form/table/tbody/tr[5]/td"));
            btn.Click();
        }

    }
}
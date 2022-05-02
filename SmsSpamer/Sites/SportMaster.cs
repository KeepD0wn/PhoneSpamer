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
    class SportMaster : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://www.sportmaster.ru/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn1 = ISite.browser.FindElement(By.XPath("//*[@id='sticky-header-wrapper']/div/div[3]/button/span"));
            btn1.Click();
            Thread.Sleep(1000);

            ISite.browser.FindElement(By.XPath("//*[@id='app']/div[5]/div/div/div[2]/div/section/div[3]/span/div/label[2]/input")).SendKeys(ISite.PhoneNumberWithout7);
            IWebElement btn = ISite.browser.FindElement(By.XPath("//*[@id='app']/div[5]/div/div/div[2]/div/section/div[3]/button/span"));
            btn.Click();
        }

    }
}
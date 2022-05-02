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
    class Lenta : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://lenta.com/npl/authentication/");
            ISite.browser.Manage().Window.Maximize();

            ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[1]/div/main/div/div/div/div[2]/div/div[2]/div/div/div[1]/div[2]/div[1]/input")).SendKeys(ISite.PhoneNumberWithout7);

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[1]/div/main/div/div/div/div[2]/div/div[4]/button"));
            btn.Click();
        }

    }
}
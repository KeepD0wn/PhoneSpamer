using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PhoneSpamer.Sites
{
    class Prof33 : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://prof33.ru/");
            IWebElement btn = ISite.browser.FindElement(By.ClassName("btn"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.Name("text-198")).SendKeys(ISite.Name); 
            ISite.browser.FindElement(By.Name("tel-914")).SendKeys(ISite.PhoneNumber);
            IWebElement btnSend = ISite.browser.FindElement(By.ClassName("form-submit"));
            btnSend.Click();
        }
    }
}

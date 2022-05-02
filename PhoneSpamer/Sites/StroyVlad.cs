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
    class StroyVladISite : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://stroitelstvo-domov-vladivostok.ru/");
            ISite.browser.FindElement(By.ClassName("input-phone")).SendKeys(ISite.PhoneNumber);
            IWebElement btnSend = ISite.browser.FindElement(By.XPath("//span[@class='arrow']"));
            btnSend.Click();

        }
    }
}

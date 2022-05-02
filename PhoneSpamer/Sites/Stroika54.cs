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
    class Stroika54 : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://stroikaveka54.ru/");
            ISite.browser.Manage().Window.Maximize();
            ISite.browser.FindElement(By.XPath("//input[@name='text-name']")).SendKeys(ISite.Name); //Нахожу строку поиска Google и вписываю "Selenium"
            ISite.browser.FindElement(By.XPath("//input[@name='tel-phone']")).SendKeys(ISite.PhoneNumberWithout7);
            IWebElement btnSend = ISite.browser.FindElement(By.XPath("//input[@type='submit']"));
            btnSend.Click();
        }
    }
}

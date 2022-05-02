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
    class Telegram : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://web.telegram.org/z/");
            ISite.browser.Manage().Window.Maximize();
            Thread.Sleep(5000);

            IWebElement btn = ISite.browser.FindElement(By.XPath("//*[@id='auth-qr-form']/div/button[1]"));
            btn.Click();
            Thread.Sleep(1000);

            ISite.browser.FindElement(By.XPath("//*[@id='sign-in-phone-number']")).SendKeys(ISite.PhoneNumberWithout7); //Нахожу строку поиска Google и вписываю "Selenium"
            //browser.FindElement(By.XPath("//input[@name='tel-phone']")).SendKeys(ISite.phoneNumberWithout7);
            IWebElement btnSend = ISite.browser.FindElement(By.XPath("//*[@id='auth-phone-number-form']/div/form/button[1]/div"));
            btnSend.Click();
        }
    }
}
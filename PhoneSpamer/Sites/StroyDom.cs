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
    class StroyDom : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://stroitelstvo-vladivostok.ru/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div[1]/header/div/div/div[5]/div[3]/a"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("//*[@id='name-modal-call-form']")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("//*[@id='phone-modal-call-form']")).SendKeys(ISite.PhoneNumberWithout7); //Нахожу строку поиска Google и вписываю "Selenium"

            IWebElement btnSend = ISite.browser.FindElement(By.XPath("//*[@id='call-modal']/div[2]/div/form/div[3]/button"));
            btnSend.Click();
        }
    }
}
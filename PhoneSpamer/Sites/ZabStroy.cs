using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PhoneSpamer.Sites
{
    class ZabStroy : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://zabstroiremont.ru/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("//*[@id='mrb-button-block']/a/span"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("//*[@id='fio']")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("//*[@id='phone']")).SendKeys(ISite.PhoneNumber); //Нахожу строку поиска Google и вписываю "Selenium"
            ISite.browser.FindElement(By.XPath("//*[@id='content']")).SendKeys(ISite.mail);

            IWebElement btnSend = ISite.browser.FindElement(By.XPath("//*[@id='1-edit-window']/div/footer/div/div[2]/a/button"));
            btnSend.Click();
        }
    }
}
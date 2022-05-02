using System;
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
    class BukVina : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://bukovinadv.ru/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div[1]/header/a"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("//*[@id='add-book-calc__name']")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("//*[@id='add-book-calc__phone']")).SendKeys(ISite.PhoneNumber); //Нахожу строку поиска Google и вписываю "Selenium"

            IWebElement btnSend = ISite.browser.FindElement(By.XPath("//*[@id='modal-popup-book']/div/form/button"));
            btnSend.Click();
        }
    }
}
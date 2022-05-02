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
    class RemontVladivostok : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://remont-kvartir-vladivostok.ru/");
            ISite.browser.Manage().Window.Maximize();
            IWebElement btn = ISite.browser.FindElement(By.ClassName("header-top-right-action__btn"));
            btn.Click();
            //  Thread.Sleep(1000);           
            ISite.browser.FindElement(By.Name("Имя")).SendKeys(ISite.Name); //Нахожу строку поиска Google и вписываю "Selenium"
            ISite.browser.FindElement(By.Name("Телефон")).SendKeys(ISite.PhoneNumber);           
            IWebElement btnSend = ISite.browser.FindElement(By.ClassName("popup-container")).FindElement(By.ClassName("office-content__btn"));
            btnSend.Click();
        }
    }
}

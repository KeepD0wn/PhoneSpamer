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
    class PodKluch : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://vladimir.vse-podklyuch.ru/");
            ISite.browser.Manage().Window.Maximize();
            Thread.Sleep(8000);
            IWebElement btn = ISite.browser.FindElement(By.ClassName("ghost-btn"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.Id("call-me-name")).SendKeys(ISite.Name); //Нахожу строку поиска Google и вписываю "Selenium"
            ISite.browser.FindElement(By.Id("call-me-phone")).SendKeys(ISite.PhoneNumber);
            IWebElement toggle = ISite.browser.FindElement(By.Id("call-me-privacy"));
            toggle.Click();
            IWebElement footer = ISite.browser.FindElement(By.ClassName("modal-footer"));
            IWebElement btnSend = footer.FindElement(By.ClassName("submit"));
            btnSend.Click();     
        }
    }
}

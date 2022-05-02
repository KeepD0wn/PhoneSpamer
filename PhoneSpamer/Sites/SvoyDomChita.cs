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
    class SvoyDomChita : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://xn--80adgqdtlcwr7c.xn--p1ai/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div/header/div[2]/div/nav/a"));
            btn.Click();
            Thread.Sleep(1000);
           // browser.FindElement(By.XPath("//*[@id='name']")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("//*[@id='callback-modal']/div/form/input[1]")).SendKeys(ISite.PhoneNumberWithout7); //Нахожу строку поиска Google и вписываю "Selenium"
           

            IWebElement btnSend = ISite.browser.FindElement(By.XPath("//*[@id='callback-modal']/div/form/input[15]"));
            btnSend.Click();
        }
    }
}
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
    class Demetra : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://www.demetrastroi.ru/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/nav/div/div[2]/div/div[2]/a"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("//*[@id='name']")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("//*[@id='tel']")).SendKeys(ISite.PhoneNumber); //Нахожу строку поиска Google и вписываю "Selenium"
            ISite.browser.FindElement(By.XPath("//*[@id='email']")).SendKeys(ISite.mail);

            IWebElement btnSend = ISite.browser.FindElement(By.XPath("//*[@id='zvonokrecall']/div/div/div[1]/form/div[2]"));
            btnSend.Click();
        }
    }
}
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
    class StroyLes27 : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://stroyles27.ru/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div[1]/header/div/div/div[5]/div[3]/a"));
            btn.Click();
            Thread.Sleep(6000);
            ISite.browser.FindElement(By.XPath("/html/body/div[9]/div[2]/div/form/div[1]/input")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("/html/body/div[9]/div[2]/div/form/div[2]/input")).SendKeys(ISite.PhoneNumber); //Нахожу строку поиска Google и вписываю "Selenium"


            IWebElement btnSend = ISite.browser.FindElement(By.XPath("/html/body/div[9]/div[2]/div/form/div[3]/button"));
            btnSend.Click();
        }
    }
}
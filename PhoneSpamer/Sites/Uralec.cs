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
    class Uralec : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://www.remont-uralec.ru/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div[2]/a[1]"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("/html/body/div[22]/form/div[1]/input[1]")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("/html/body/div[22]/form/div[1]/input[2]")).SendKeys(ISite.PhoneNumber); //Нахожу строку поиска Google и вписываю "Selenium"


            IWebElement btnSend = ISite.browser.FindElement(By.XPath("/html/body/div[22]/form/div[4]/input"));
            btnSend.Click();
        }
    }
}
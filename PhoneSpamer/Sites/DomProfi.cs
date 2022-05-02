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
    class DomProfi : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://domprofi24.ru/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div[2]/div/div[1]/div/div/div[2]/p/a"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("/html/body/div[8]/div/div/div[2]/div/form/p[1]/label/span/input")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("/html/body/div[8]/div/div/div[2]/div/form/p[2]/label/span/input")).SendKeys(ISite.PhoneNumber); //Нахожу строку поиска Google и вписываю "Selenium"


            IWebElement btnSend = ISite.browser.FindElement(By.XPath("/html/body/div[8]/div/div/div[2]/div/form/p[2]/input"));
            btnSend.Click();
        }
    }
}
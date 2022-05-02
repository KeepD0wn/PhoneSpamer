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
    class Rm27 : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://rm-27.ru/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/header/div[1]/div/div/div[3]/div/a/small"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("/html/body/div[4]/div/div/form/div[1]/div[2]/div[1]/input")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("/html/body/div[4]/div/div/form/div[1]/div[2]/div[2]/input")).SendKeys(ISite.PhoneNumber); //Нахожу строку поиска Google и вписываю "Selenium"
            

            IWebElement btnSend = ISite.browser.FindElement(By.XPath("/html/body/div[4]/div/div/form/div[2]/div[2]/button"));
            btnSend.Click();
        }
    }
}
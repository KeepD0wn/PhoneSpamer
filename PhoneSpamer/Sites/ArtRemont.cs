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
    class ArtRemont : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://art-remont.ru/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div[2]/div[1]/div[2]/div[4]/div/div/div"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("/html/body/div[3]/div[2]/div[2]/div[2]/div/form/div/div[1]/input")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("/html/body/div[3]/div[2]/div[2]/div[2]/div/form/div/div[2]/input")).SendKeys("+"+ISite.PhoneNumber); //Нахожу строку поиска Google и вписываю "Selenium"
           

            IWebElement btnSend = ISite.browser.FindElement(By.XPath("/html/body/div[3]/div[2]/div[2]/div[2]/div/form/div/div[4]/input"));
            btnSend.Click();
        }
    }
}
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
    class Kit27 : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://sk-kit27.ru/");
            ISite.browser.Manage().Window.Maximize();

            //IWebElement btn = browser.FindElement(By.XPath("/html/body/a[1]"));
            //btn.Click();
            //Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("/html/body/div[1]/section[1]/div/form/div[1]/div[4]/input[1]")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("/html/body/div[1]/section[1]/div/form/div[1]/div[4]/input[2]")).SendKeys(ISite.PhoneNumber); //Нахожу строку поиска Google и вписываю "Selenium"


            IWebElement btnSend = ISite.browser.FindElement(By.XPath("/html/body/div[1]/section[1]/div/form/div[2]/a"));
            btnSend.Click();
        }
    }
}
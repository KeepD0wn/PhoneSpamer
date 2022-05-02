using System;
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
    class ArtemBurov : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://artemburvod.ru/#form");
            ISite.browser.Manage().Window.Maximize();

            //IWebElement btn = browser.FindElement(By.XPath("/html/body/div/header/div[2]/div/nav/a"));
            //btn.Click();
            //Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("/html/body/div[1]/section[13]/div[2]/form/div[2]/div/div[1]/input")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("/html/body/div[1]/section[13]/div[2]/form/div[3]/div/div[1]/input")).SendKeys(ISite.PhoneNumber); //Нахожу строку поиска Google и вписываю "Selenium"
            

            IWebElement btnSend = ISite.browser.FindElement(By.XPath("/html/body/div[1]/section[13]/div[2]/form/div[4]/input"));
            btnSend.Click();
        }
    }
}
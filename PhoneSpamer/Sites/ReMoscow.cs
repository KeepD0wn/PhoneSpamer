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
    class ReMoscow : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://remo.moscow/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div[1]/div/header/div[3]/a"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("//*[@id='zamer_popup']/div[2]/form/div[2]/input")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("/html/body/div[3]/div[2]/div[2]/form/div[3]/input")).SendKeys(ISite.PhoneNumber); //Нахожу строку поиска Google и вписываю "Selenium"
            ISite.browser.FindElement(By.XPath("//*[@id='zamer_popup']/div[2]/form/div[4]/input")).SendKeys(ISite.mail);

            IWebElement btnSend = ISite.browser.FindElement(By.XPath("//*[@id='zamer_popup']/div[2]/form/button"));
            btnSend.Click();
        }
    }
}
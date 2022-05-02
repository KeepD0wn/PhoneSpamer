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
    class RemontEKB : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://xn--90ahauiggnw.xn--p1ai/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/header/section[2]/article/a[2]"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("/html/body/div[3]/div/div/div/div/div/div/div[2]/form/div[1]/input")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("/html/body/div[3]/div/div/div/div/div/div/div[2]/form/div[2]/input")).SendKeys(ISite.PhoneNumberWithout7); //Нахожу строку поиска Google и вписываю "Selenium"


            IWebElement btnSend = ISite.browser.FindElement(By.XPath("/html/body/div[3]/div/div/div/div/div/div/div[2]/form/button"));
            btnSend.Click();
        }
    }
}
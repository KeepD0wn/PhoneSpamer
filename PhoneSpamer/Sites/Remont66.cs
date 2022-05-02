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
    class Remont66 : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://remont-66.ru/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div/div/div/header/div[1]/div/div/a[2]"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("/html/body/div/div/div/header/div[2]/div/div/div/div/div[3]/div[1]/div[2]/input")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("/html/body/div/div/div/header/div[2]/div/div/div/div/div[3]/div[2]/div[2]/div/input")).SendKeys(ISite.PhoneNumberWithout7); //Нахожу строку поиска Google и вписываю "Selenium"


            IWebElement btnSend = ISite.browser.FindElement(By.XPath("/html/body/div/div/div/header/div[2]/div/div/div/div/div[4]/div[1]"));
            btnSend.Click();
        }
    }
}
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
    class Sdelano : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://sdelano.ru/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("//*[@id='main']/div/div[1]/div[1]/div[2]/div/div/div/div/a"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("//*[@id='popup']/div/div[1]/div[2]/div/div/div/div[2]/div/div/form/div[1]/div[1]/input")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("//*[@id='popup']/div/div[1]/div[2]/div/div/div/div[2]/div/div/form/div[1]/div[2]/input")).SendKeys(ISite.PhoneNumberWithout7); //Нахожу строку поиска Google и вписываю "Selenium"


            IWebElement btnSend = ISite.browser.FindElement(By.XPath("//*[@id='popup']/div/div[1]/div[2]/div/div/div/div[2]/div/div/form/div[1]/button/span"));
            btnSend.Click();
        }
    }
}
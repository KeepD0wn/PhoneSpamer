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
    class Gikodv : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://gikodv.ru/info/price/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div[4]/header/div[1]/div[1]/div/div[2]/div[2]/div[1]/div/span"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("//*[@id='FIO']")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("//*[@id='PHONE']")).SendKeys(ISite.PhoneNumberWithout7); //Нахожу строку поиска Google и вписываю "Selenium"


            IWebElement btnSend = ISite.browser.FindElement(By.XPath("/html/body/div[21]/div/div/form/div[3]/div[2]/button"));
            btnSend.Click();
        }
    }
}
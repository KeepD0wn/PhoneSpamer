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
    class ElGrans : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://elgrans.ru/remont-kvartir/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div[1]/div[4]/a[1]"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div/form/div[1]/input")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div/form/div[2]/input")).SendKeys(ISite.PhoneNumberWithout7); //Нахожу строку поиска Google и вписываю "Selenium"


            IWebElement btnSend = ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div/form/button"));
            btnSend.Click();
        }
    }
}
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
    class Pik : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://pik-remont.ru/");
            ISite.browser.Manage().Window.Maximize();

            //IWebElement btn = browser.FindElement(By.XPath("/html/body/header/div[2]/div/div/a[1]"));
            //btn.Click();
            //Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("//*[@id='1']/div/div/form/input[1]")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("//*[@id='1']/div/div/form/input[2]")).SendKeys(ISite.PhoneNumberWithout7); //Нахожу строку поиска Google и вписываю "Selenium"
            ISite.browser.FindElement(By.XPath("//*[@id='1']/div/div/form/input[3]")).SendKeys(ISite.mail);

            IWebElement btnSend = ISite.browser.FindElement(By.XPath("//*[@id='1']/div/div/form/button"));
            btnSend.Click();
        }
    }
}
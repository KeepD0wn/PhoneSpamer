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
    class SckvashinaVlad : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://scvazhina.ru/vladivostok/");
            ISite.browser.Manage().Window.Maximize();

            //IWebElement btn = browser.FindElement(By.XPath("/html/body/div/header/div[2]/div/nav/a"));
            //btn.Click();
            //Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("/html/body/header/div[2]/div[1]/div[1]/form/input[2]")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("/html/body/header/div[2]/div[1]/div[1]/form/input[3]")).SendKeys(ISite.PhoneNumberWithout7); //Нахожу строку поиска Google и вписываю "Selenium"
            ISite.browser.FindElement(By.XPath("/html/body/header/div[2]/div[1]/div[1]/form/input[4]")).SendKeys("Ленинский");

            IWebElement btnSend = ISite.browser.FindElement(By.XPath("/html/body/header/div[2]/div[1]/div[1]/form/button"));
            btnSend.Click();
        }
    }
}
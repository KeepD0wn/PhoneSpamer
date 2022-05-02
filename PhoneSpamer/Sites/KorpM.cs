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
    class KorpM : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://korp-m.ru/proektirovanie/stroitelstvo-domov/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/header/div[1]/div[6]/button"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/form/div[2]/input")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/form/div[3]/input")).SendKeys(ISite.PhoneNumber); //Нахожу строку поиска Google и вписываю "Selenium"


            IWebElement btnSend = ISite.browser.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/form/div[4]/div/input"));
            btnSend.Click();
        }
    }
}
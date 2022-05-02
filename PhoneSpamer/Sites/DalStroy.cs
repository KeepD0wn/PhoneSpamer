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
    class DalStroy : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("http://dv-stm.ru/usluhi/stroitelstvo-i-remont/stroiteltsvo-domov");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/p[5]/a"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("/html/body/div[2]/div/div[1]/div/div/form/div/div[1]/input")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("/html/body/div[2]/div/div[1]/div/div/form/div/div[2]/input")).SendKeys(ISite.PhoneNumber); //Нахожу строку поиска Google и вписываю "Selenium"


            IWebElement btnSend = ISite.browser.FindElement(By.XPath("/html/body/div[2]/div/div[1]/div/div/form/div/div[3]/input"));
            btnSend.Click();
        }
    }
}
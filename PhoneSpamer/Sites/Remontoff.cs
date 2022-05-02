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
    class Remontoff : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://remontoff-ekb.ru/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div[1]/div/div/main/section[3]/div/div/div[1]/div/div/div[5]/button/span[3]"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("/html/body/div[9]/div/div/section/div/div/div/div/div/div[4]/div/div/form/center[1]/span[1]/input")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("/html/body/div[9]/div/div/section/div/div/div/div/div/div[4]/div/div/form/center[1]/span[2]/input")).SendKeys(ISite.PhoneNumber); //Нахожу строку поиска Google и вписываю "Selenium"


            IWebElement btnSend = ISite.browser.FindElement(By.XPath("/html/body/div[9]/div/div/section/div/div/div/div/div/div[4]/div/div/form/center[2]/input"));
            btnSend.Click();
        }
    }
}
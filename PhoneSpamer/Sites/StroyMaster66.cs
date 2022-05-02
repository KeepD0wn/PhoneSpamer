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
    class StroyMaster66 : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://www.stroy-master66.ru/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/a[1]"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("/html/body/div[4]/div[2]/div[4]/div/div/div/form/input[5]")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("/html/body/div[4]/div[2]/div[4]/div/div/div/form/input[6]")).SendKeys(ISite.PhoneNumber); //Нахожу строку поиска Google и вписываю "Selenium"


            IWebElement btnSend = ISite.browser.FindElement(By.XPath("/html/body/div[4]/div[2]/div[4]/div/div/div/form/span[2]/input"));
            btnSend.Click();
        }
    }
}
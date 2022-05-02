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
    class Avangard : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("http://www.ads-irk.ru/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[2]/a[1]/span"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("//*[@id='signup-ct']/form/input[1]")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("//*[@id='signup-ct']/form/input[2]")).SendKeys(ISite.PhoneNumber); //Нахожу строку поиска Google и вписываю "Selenium"

            IWebElement btnSend = ISite.browser.FindElement(By.XPath("//*[@id='signup-ct']/form/input[4]"));
            btnSend.Click();
        }
    }
}
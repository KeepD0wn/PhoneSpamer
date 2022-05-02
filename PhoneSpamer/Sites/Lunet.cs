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
    class Lunet : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://xn--28-dlcajeuzloebbsofldd2r.xn--p1ai/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div[4]/p/a"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("/html/body/div[17]/div/div/div[2]/div/form/div[1]/input")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("/html/body/div[17]/div/div/div[2]/div/form/div[3]/input")).SendKeys(ISite.PhoneNumberWithout7); //Нахожу строку поиска Google и вписываю "Selenium"

            IWebElement btnSend = ISite.browser.FindElement(By.XPath("/html/body/div[17]/div/div/div[2]/div/form/p/button"));
            btnSend.Click();
        }
    }
}
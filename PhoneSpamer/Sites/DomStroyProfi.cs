using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace PhoneSpamer.Sites
{
    class DomStroyProfi : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://domstroyprofi.ru/vladivostok");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("//*[@id='header']/div[1]/div/div[3]/a"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("//*[@id='contact-form']/div[2]/input[1]")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[8]/div/div[4]/div[2]/form/div[2]/input[2]")).SendKeys(ISite.PhoneNumberWithout7); //Нахожу строку поиска Google и вписываю "Selenium"

            IWebElement btnSend = ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[8]/div/div[4]/div[2]/form/div[3]/input"));
            btnSend.Click();
        }
    }
}
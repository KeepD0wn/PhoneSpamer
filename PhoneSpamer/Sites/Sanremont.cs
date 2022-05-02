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
    class Sanremont : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://sanremo-nsk.ru/");
            ISite.browser.Manage().Window.Maximize();
            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div[1]/div/header/div/div[5]/a"));
            btn.Click();
            ISite.browser.FindElement(By.XPath("//*[@id='popupRecallForm']/input[1]")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("//*[@id='popupRecallForm']/input[2]")).SendKeys(ISite.PhoneNumber); //Нахожу строку поиска Google и вписываю "Selenium"
            //browser.FindElement(By.XPath("//input[@name='tel-phone']")).SendKeys(ISite.phoneNumberWithout7);
            IWebElement btnSend = ISite.browser.FindElement(By.XPath("//*[@id='popupRecallForm']/input[5]"));
            btnSend.Click();
        }
    }
}
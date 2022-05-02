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
    class PartnerStroy : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("http://partner-stroi.com/index.php/contacts");
            ISite.browser.Manage().Window.Maximize();

            //IWebElement btn = browser.FindElement(By.XPath("/html/body/div[4]/header/div[1]/div[1]/div/div[2]/div[2]/div[1]/div/span"));
            //btn.Click();
            //Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("/html/body/div[2]/footer/div[1]/div/div/div[2]/div/div[2]/div/div/form/input[2]")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("/html/body/div[2]/footer/div[1]/div/div/div[2]/div/div[2]/div/div/form/input[3]")).SendKeys(ISite.PhoneNumber); //Нахожу строку поиска Google и вписываю "Selenium"


            IWebElement btnSend = ISite.browser.FindElement(By.XPath("/html/body/div[2]/footer/div[1]/div/div/div[2]/div/div[2]/div/div/form/input[4]"));
            btnSend.Click();
        }
    }
}
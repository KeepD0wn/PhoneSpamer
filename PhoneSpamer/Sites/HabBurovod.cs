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
    class HabBurovod : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://habburvod.ru/#");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div[3]/header/div[1]/div[2]/div/div/div/div[4]/a"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("//*[@id='request_call_form']/label[1]/input")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("//*[@id='request_call_form']/label[2]/input")).SendKeys(ISite.PhoneNumber); //Нахожу строку поиска Google и вписываю "Selenium"
            
            IWebElement btnSend = ISite.browser.FindElement(By.XPath("//*[@id='request_call_form']/input[3]"));
            btnSend.Click();
        }
    }
}
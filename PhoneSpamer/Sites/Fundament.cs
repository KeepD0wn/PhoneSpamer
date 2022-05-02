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
    class Fundament : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://remont-f.ru/remont-kvartir-pod-kluch/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("//*[@id='call_form']"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("//*[@id='call_screen']/div/form/label[1]/input")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("//*[@id='call_screen']/div/form/label[2]/input")).SendKeys(ISite.PhoneNumberWithout7); //Нахожу строку поиска Google и вписываю "Selenium"
          

            IWebElement btnSend = ISite.browser.FindElement(By.XPath("//*[@id='call_screen']/div/form/button"));
            btnSend.Click();
        }
    }
}
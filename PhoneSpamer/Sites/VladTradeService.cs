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
    class VladTradeService : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://vladivostok.trade-services.ru/services/burenie-skvazhin/");
            ISite.browser.Manage().Window.Maximize();

            //IWebElement btn = browser.FindElement(By.XPath("/html/body/div/header/div[2]/div/nav/a"));
            //btn.Click();
            //Thread.Sleep(1000);
            //browser.FindElement(By.XPath("/html/body/div[1]/section[13]/div[2]/form/div[2]/div/div[1]/input")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div[3]/div/form/div[1]/input")).SendKeys(ISite.PhoneNumber); //Нахожу строку поиска Google и вписываю "Selenium"
            ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div[3]/div/form/div[2]/input")).SendKeys(ISite.mail);

            IWebElement btnSend = ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div[3]/div/form/input"));
            btnSend.Click();
        }
    }
}
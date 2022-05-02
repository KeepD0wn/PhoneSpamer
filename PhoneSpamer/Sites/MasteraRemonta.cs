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
    class MasteraRemonta : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://mastera-remonta.com/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("//*[@id='header']/div/div/div[3]/div/div[3]/a"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("//*[@id='modal-call1_header2']/div[1]/input")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("/html/body/div[21]/div[2]/div[4]/div/div/div[2]/div[1]/div/div[1]/form/div[2]/input")).SendKeys(ISite.PhoneNumberWithout7); //Нахожу строку поиска Google и вписываю "Selenium"


            IWebElement btnSend = ISite.browser.FindElement(By.XPath("/html/body/div[21]/div[2]/div[4]/div/div/div[2]/div[1]/div/div[1]/form/input[18]"));
            btnSend.Click();
        }
    }
}
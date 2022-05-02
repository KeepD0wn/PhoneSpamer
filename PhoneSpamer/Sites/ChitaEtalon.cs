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
    class ChitaEtalon : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://chita.etalon-remont.ru/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[2]/div/ul/li/div[4]/div/div/div[3]/div/h2/button"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[5]/div[7]/div[2]/div/div[2]/div/div[2]/form/fieldset/section[1]/label[2]/input")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[5]/div[7]/div[2]/div/div[2]/div/div[2]/form/fieldset/section[2]/label[2]/input")).SendKeys(ISite.PhoneNumberWithout7); //Нахожу строку поиска Google и вписываю "Selenium"
            ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[5]/div[7]/div[2]/div/div[2]/div/div[2]/form/fieldset/section[3]/label[2]/input")).SendKeys(ISite.mail);

            IWebElement btnSend = ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[5]/div[7]/div[2]/div/div[2]/div/div[2]/form/footer/button"));
            btnSend.Click();
        }
    }
}
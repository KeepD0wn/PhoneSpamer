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
    class Vitoslavica : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://vitoslavica.ru/doma-iz-brusa/vladivostok.html");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("//*[@id='callback-btn-open-popup']/p/span"));
            btn.Click();
            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("//*[@id='callbackphone-22']/div/form/div[1]/span[1]/input")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("//*[@id='callbackphone-22']/div/form/div[2]/input")).SendKeys(ISite.PhoneNumber); //Нахожу строку поиска Google и вписываю "Selenium"
            ISite.browser.FindElement(By.XPath("//*[@id='callbackphone-22']/div/form/div[2]/span/input")).SendKeys(ISite.mail);

            IWebElement btnSend = ISite.browser.FindElement(By.XPath("//*[@id='callbackphone-22']/div/form/input[1]"));
            btnSend.Click();
        }
    }
}
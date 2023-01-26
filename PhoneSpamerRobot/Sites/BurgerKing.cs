using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PhoneSpamerRobot.Sites
{
    class BurgerKing : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://burgerkingrus.ru/");
            ISite.browser.Manage().Window.Maximize();

            try
            {
                IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div/div/div/header/div/div[2]/div/div/span"));
                btn.Click();
                Thread.Sleep(1000);

                ISite.browser.FindElement(By.XPath("/html/body/div/div/div/div[3]/div/div[2]/div/label[1]/input")).SendKeys(ISite.PhoneNumberWithout7);
                Thread.Sleep(5000);
                IWebElement btn0 = ISite.browser.FindElement(By.XPath("/html/body/div/div/div/div[3]/div/div[2]/div/label[3]/input"));
                btn0.Click();
                Thread.Sleep(500);

                IWebElement btnSend = ISite.browser.FindElement(By.XPath("/html/body/div/div/div/div[3]/div/div[2]/div/div[3]"));
                btnSend.Click();
            }
            catch
            {
                throw new SiteHTMLException(" exception with HTML");
            }
            
        }
    }
}

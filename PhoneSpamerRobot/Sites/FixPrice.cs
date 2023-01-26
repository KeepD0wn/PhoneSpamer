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
    class FixPrice : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://fix-price.com/");
            ISite.browser.Manage().Window.Maximize();

            try
            {
                IWebElement btn9 = ISite.browser.FindElement(By.XPath("//*[@id=\"app-header\"]/header/div/div[2]/div[4]/button/span"));
                btn9.Click();

                IWebElement btn8 = ISite.browser.FindElement(By.XPath("//*[@id=\"modal\"]/div/div/button[3]"));
                btn8.Click();

                ISite.browser.FindElement(By.XPath("//*[@id=\"modal\"]/div/div/div/div[1]/div/input")).SendKeys(ISite.PhoneNumberWithout7);
                Thread.Sleep(500);
               
                IWebElement btn = ISite.browser.FindElement(By.XPath("//*[@id=\"modal\"]/div/div/div/button"));
                btn.Click();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(this.ToString() + " entered phone");
                Console.ResetColor();
            }
            catch
            {
                throw new SiteHTMLException(" exception with HTML");
            }
        }
    }
}
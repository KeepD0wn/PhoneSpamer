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
    class DetMir : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://www.detmir.ru/");
            ISite.browser.Manage().Window.Maximize();

            try
            {
                IWebElement btn1 = ISite.browser.FindElement(By.XPath("/html/body/div[3]/div[2]/header/div/div[3]/div/div/div/div/span/div"));
                btn1.Click();
                Thread.Sleep(1000);

                IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div[4]/div[4]/div/div/div[2]/div/div/button[2]/div/div"));
                btn.Click();
                Thread.Sleep(1000);

                ISite.browser.FindElement(By.XPath("/html/body/div[4]/div[5]/div/div/div[2]/div/div/div[1]/label/input")).SendKeys(ISite.PhoneNumberWithout7);
                Thread.Sleep(1000);

                IWebElement btn2 = ISite.browser.FindElement(By.XPath("/html/body/div[4]/div[5]/div/div/div[2]/div/div/button/div/div"));
                btn2.Click();

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
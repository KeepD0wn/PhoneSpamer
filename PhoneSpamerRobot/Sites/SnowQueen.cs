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
    class SnowQueen : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://snowqueen.ru/customer/account/login");
            ISite.browser.Manage().Window.Maximize();

            try
            {
                IWebElement btn1 = ISite.browser.FindElement(By.XPath("/html/body/div[1]/div/div[1]/section[3]/div/div/div/div/div[1]/span"));
                btn1.Click();
                Thread.Sleep(1000);

                ISite.browser.FindElement(By.XPath("/html/body/div/div/div[1]/section[3]/div/div/div/div/div[2]/div/div[1]/div/input")).SendKeys(ISite.PhoneNumber);
                Thread.Sleep(1000);

                IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div/div/div[1]/section[3]/div/div/div/div/div[2]/div/button/span"));
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
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
    class Cian : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://vladimir.cian.ru/");
            ISite.browser.Manage().Window.Maximize();

            try
            {
                Thread.Sleep(10000);
                IWebElement btn = ISite.browser.FindElement(By.XPath("//*[@id='header-frontend']/div/div/div/a/span"));
                btn.Click();
                Thread.Sleep(1000);

                ISite.browser.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/div/div/div/div[2]/div/form/div[1]/div/div/input")).SendKeys(ISite.PhoneNumber);

                Thread.Sleep(1000);

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

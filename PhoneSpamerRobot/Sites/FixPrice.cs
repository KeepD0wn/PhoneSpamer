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
            ISite.browser.Navigate().GoToUrl("https://fix-price.ru/auth/register.php");
            ISite.browser.Manage().Window.Maximize();

            try
            {
                ISite.browser.FindElement(By.XPath("/html/body/div[4]/main/div[3]/div/div/div[4]/form/fieldset[2]/div/div/div[2]/input[1]")).SendKeys(ISite.PhoneNumberWithout7);
                Thread.Sleep(1000);
               
                IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div[4]/main/div[3]/div/div/div[4]/form/fieldset[2]/div/div/div[2]/span"));
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
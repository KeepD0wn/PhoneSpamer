using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SmsSpamer.Sites
{
    class JustFood : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://www.justfood.pro/");
            ISite.browser.Manage().Window.Maximize();
                        
            IWebElement btn1 = ISite.browser.FindElement(By.XPath("//*[@id='app-header']/app-header/div/div/app-header-desktop/div[2]/button"));
            btn1.Click();
            Thread.Sleep(1000);

            ISite.browser.FindElement(By.XPath("//*[@id='phone']")).SendKeys(ISite.PhoneNumberWithout7);

            IWebElement btn = ISite.browser.FindElement(By.XPath("//*[@id='mat-dialog-0']/app-auth-modal/div/div[3]/app-authorization/form/button/span"));
            btn.Click();
        }

    }
}
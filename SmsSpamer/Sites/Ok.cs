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
    class Ok : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://ok.ru/dk?st.cmd=anonymRegistrationEnterPhone");
            ISite.browser.Manage().Window.Maximize();
                        
            ISite.browser.FindElement(By.XPath("/html/body/div[10]/div[5]/div[3]/div[1]/div/div/div/div[1]/div[3]/div/div/div/div/div/div[1]/div[2]/div/form/div[1]/div[1]/div[1]/input")).SendKeys(ISite.PhoneNumberWithout7);

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div[10]/div[5]/div[3]/div[1]/div/div/div/div[1]/div[3]/div/div/div/div/div/div[1]/div[2]/div/form/div[2]/input"));
            btn.Click();
        }

    }
}
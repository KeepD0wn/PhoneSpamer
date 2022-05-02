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
    class MVideo : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://www.mvideo.ru/");
            ISite.browser.Manage().Window.Maximize();

            Thread.Sleep(1000);
            IWebElement btn1 = ISite.browser.FindElement(By.XPath("/html/body/mvid-root/div/mvid-primary-layout/mvid-layout/div/div[1]/mvid-header-container/mvid-header/header/div[2]/div/mvid-tap-bar/div/div[3]/mvid-header-icon/div/a/p"));
            btn1.Click();
            Thread.Sleep(2000);

            ISite.browser.FindElement(By.XPath("//*[@id='mvideo-form-field-input-0']")).SendKeys(ISite.PhoneNumberWithout7);
            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/mvid-root/mvid-modals-container/div/mvid-modal/div/div/div/div/mvid-login-form/mvid-login-form-phone/form/div[2]/div/button/div"));
            btn.Click();
        }

    }
}
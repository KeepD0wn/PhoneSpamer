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
    class Yota : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://www.yota.ru/voice/order-sim");
            ISite.browser.Manage().Window.Maximize();

            Thread.Sleep(1000);
            ISite.browser.FindElement(By.XPath("//*[@id='orderPhone']")).SendKeys(ISite.PhoneNumberWithout7);
            Thread.Sleep(500);

            IWebElement btn = ISite.browser.FindElement(By.XPath("//*[@id='p_p_id_yotagoodsorder_WAR_ecommerceportlet_']/div/div/div/div[1]/div[2]/div[2]/div/button"));
            btn.Click();
        }

    }
}
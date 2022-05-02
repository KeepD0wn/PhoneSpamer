using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PhoneSpamer.Sites
{
    class AvanStroy : ISite
    {
        public void SpamSite()
        {           
            ISite.browser.Navigate().GoToUrl("https://xn--80aaelrgdemkkfrhbaqled.xn--p1ai/remont-i-otdelka/remont-kvartir-pod-klyuch-v-novosibirske");
            ISite.browser.Manage().Window.Maximize();
            //IWebElement btn = browser.FindElement(By.XPath("//input[@name='phone']"));
            //btn.Click();
            ISite.browser.FindElement(By.XPath("//input[@name='phone']")).SendKeys(ISite.PhoneNumberWithout7); //Нахожу строку поиска Google и вписываю "Selenium"
            //browser.FindElement(By.XPath("//input[@name='tel-phone']")).SendKeys(ISite.phoneNumberWithout7);
            IWebElement btnSend = ISite.browser.FindElement(By.XPath("//*[@id='qx-custom-html-87377']/div/form/div[2]/button")); 
            btnSend.Click();
        }
    }
}
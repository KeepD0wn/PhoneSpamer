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
    class DeluveryClub : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://www.delivery-club.ru/moscow");
            ISite.browser.Manage().Window.Maximize();
            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[1]/header/div[1]/div[4]/button"));
            btn.Click();
            ISite.browser.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div/div/div[2]/div[1]/div[1]/label/input")).SendKeys(ISite.PhoneNumberWithout7); //Нахожу строку поиска Google и вписываю "Selenium"
            //browser.FindElement(By.XPath("//input[@name='tel-phone']")).SendKeys(ISite.phoneNumberWithout7);
            //IWebElement btnSend = ISite.browser.FindElement(By.XPath("//*[@id='qx-custom-html-87377']/div/form/div[2]/button"));
            //btnSend.Click();
        }
    }
}
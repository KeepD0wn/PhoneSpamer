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
    class Pochta : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://passport.pochta.ru/pc/ext/v2.0/form/signUp?callbackurl=https%3A%2F%2Fpassport.pochta.ru%2Foauth2%2Fauthorize%3Fresponse_type%3Dcode%26client_id%3DAR_mfCjWzYuiXUhIeEuTAVQKc5Ma%26redirect_uri%3Dhttps%3A%2F%2Fotpravka.pochta.ru%2Fauth%26scope%3Dopenid%2Bemail%2Bphone%2BfirstName%2BlastName%2BmiddleName%26state%3DaHR0cHM6Ly9vdHByYXZrYS5wb2NodGEucnUvZGFzaGJvYXJk&display=page&dm=l#/");
            ISite.browser.Manage().Window.Maximize();

            ISite.browser.FindElement(By.XPath("//*[@id='telMask']")).SendKeys(ISite.PhoneNumberWithout7);
            ISite.browser.FindElement(By.XPath("//*[@id='pwd']")).SendKeys("QoyGbh72");
            ISite.browser.FindElement(By.XPath("//*[@id='email']")).SendKeys(ISite.mail);

            IWebElement btn0 = ISite.browser.FindElement(By.XPath("//*[@id='root']/div/div/form/div[2]/label/span"));
            btn0.Click();

            IWebElement btn = ISite.browser.FindElement(By.XPath("//*[@id='root']/div/div/form/div[3]/button/span"));
            btn.Click();
        }

    }
}
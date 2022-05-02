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
    class Otdelochnik33 : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://xn--33-jlcepmfqfd4b2d.xn--p1ai/");            
            ISite.browser.FindElement(By.Name("custom_U102184")).SendKeys(ISite.PhoneNumberWithout7); //Нахожу строку поиска Google и вписываю "Selenium"
            IWebElement btnSend = ISite.browser.FindElement(By.ClassName("submit-btn"));
            btnSend.Click();
            
        }
    }
}

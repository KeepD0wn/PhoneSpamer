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
    class Neocomfort : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://neocomfort.ru/remont-kvartir-2/");
            ISite.browser.Manage().Window.Maximize();
            
            ISite.browser.FindElement(By.XPath("/html/body/div[4]/div/div/div/main/article/div/div/div/div[6]/div/div[2]/div/div/div/form/p[1]/label/span/input")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("/html/body/div[4]/div/div/div/main/article/div/div/div/div[6]/div/div[2]/div/div/div/form/p[2]/label/span/input")).SendKeys(ISite.PhoneNumberWithout7); //Нахожу строку поиска Google и вписываю "Selenium"
            
            IWebElement btnSend = ISite.browser.FindElement(By.XPath("/html/body/div[4]/div/div/div/main/article/div/div/div/div[6]/div/div[2]/div/div/div/form/p[6]/input"));
            btnSend.Click();
        }
    }
}
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PhoneSpamer.Sites
{
    class Domotek : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("http://xn--d1acpgjb2a.xn--p1ai/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div[6]/div/div[2]/div/div/div/div/form/div[5]/input"));
            Actions actions = new Actions(ISite.browser);
            actions.MoveToElement(btn).Perform();
            
            ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div[6]/div/div[2]/div/div/div/div/form/div[2]/label/span/input")).SendKeys(ISite.Name); 
            ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div[6]/div/div[2]/div/div/div/div/form/div[3]/label/span/input")).SendKeys(ISite.PhoneNumber); //Нахожу строку поиска Google и вписываю "Selenium"
            ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div[6]/div/div[2]/div/div/div/div/form/div[4]/label/span/input")).SendKeys(ISite.mail);

            IWebElement btnSend = ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div[6]/div/div[2]/div/div/div/div/form/div[5]/input"));
            btnSend.Click();
        }
    }
}
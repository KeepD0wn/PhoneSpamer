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
    class Dobrodom75 : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://dobrodom75.ru/final/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/footer/div/div[5]/div[5]/div"));
            btn.Click();
            Thread.Sleep(1000);
            //browser.FindElement(By.XPath("/html/body/div[1]/div[5]/div[7]/div[2]/div/div[2]/div/div[2]/form/fieldset/section[1]/label[2]/input")).SendKeys(ISite.Name);
            ISite.browser.FindElement(By.XPath("//*[@id='modal_zayavka']/div/div[2]/form/div[1]/label/input")).SendKeys(ISite.PhoneNumberWithout7); //Нахожу строку поиска Google и вписываю "Selenium"
         

            IWebElement btnSend = ISite.browser.FindElement(By.XPath("//*[@id='modal_zayavka']/div/div[2]/form/div[3]/button"));
            btnSend.Click();
        }
    }
}
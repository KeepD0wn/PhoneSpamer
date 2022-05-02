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
    class DomoDom : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("http://domodom.ru/");
            ISite.browser.Manage().Window.Maximize();

            IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[2]/div[3]/div/div[4]/div/div[2]/div/div/a/table/tbody/tr/td"));
            btn.Click();
            Thread.Sleep(1000);
           // browser.FindElement(By.XPath("//*[@id='d[0]']")).SendKeys(ISite.Name); //*[@id="d[0]"]
            ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[25]/div/div/div[2]/div/form/div[2]/div[1]/div/div[1]/input[1]")).SendKeys(ISite.PhoneNumberWithout7); //Нахожу строку поиска Google и вписываю "Selenium"

            IWebElement btnSend = ISite.browser.FindElement(By.XPath("//*[@id='comp_26ebb3d6cb4f2026a43a4f631f9ac72e']/div/form/div[3]/div[2]/button"));
            btnSend.Click();
        }
    }
}
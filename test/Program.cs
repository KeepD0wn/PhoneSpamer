using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver browser = new ChromeDriver(@"C:\Users\gvozd\Desktop");

            browser.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(1000);
            browser.Navigate().GoToUrl("https://www.citilink.ru/");
            browser.Manage().Window.Maximize();

            ((IJavaScriptExecutor)browser).ExecuteScript("window.open();");

            //DriverManager.Driver.FindElement(By.CssSelector("body")).SendKeys(Keys.Control + "t");
            browser.SwitchTo().Window(browser.WindowHandles.Last());

            browser.Navigate().GoToUrl("https://yandex.ru/pogoda/vladimir");
            browser.Manage().Window.Maximize();

            //Actions newTab = new Actions(driver);
            //newTab
            //    .KeyDown(OpenQA.Selenium.Keys.Control)
            //    .KeyDown(OpenQA.Selenium.Keys.Shift)
            //    .Click(element).KeyUp(OpenQA.Selenium.Keys.Control).KeyUp(OpenQA.Selenium.Keys.Shift)
            //    .Build()
            //    .Perform();

            //если всего будет две вкладки, то перейти на новую можно так:
            //  driver.SwitchTo().Window(driver.WindowHandles.Last());


            Console.ReadLine();
        }
    }
}

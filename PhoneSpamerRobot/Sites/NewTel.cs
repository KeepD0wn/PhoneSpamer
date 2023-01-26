using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PhoneSpamerRobot.Sites
{
    class NewTel : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://new-tel.net/");
            ISite.browser.Manage().Window.Maximize();

            try
            {
                try
                {
                    Thread.Sleep(2000);
                    IWebElement btn0 = ISite.browser.FindElement(By.XPath("/html/body/div[2]/div/div[1]/div/button"));
                    btn0.Click();
                }
                catch { }

                IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div[4]/div/ul/li[1]/a/span"));
                btn.Click();
                Thread.Sleep(1000);

               
                ISite.browser.FindElement(By.XPath("//*[@id='newtel-register-form']/div[3]/input")).SendKeys(ISite.Name);
                ISite.browser.FindElement(By.XPath("//*[@id=\"newtel-register-form\"]/div[4]/input")).SendKeys(ISite.mail);
                ISite.browser.FindElement(By.XPath("//*[@id=\"newtel-register-form\"]/div[5]/input")).SendKeys(ISite.PhoneNumberWithout7);
                Thread.Sleep(1000);

                IWebElement btn1 = ISite.browser.FindElement(By.XPath("//*[@id=\"newtel-register-form\"]/p[3]/button[1]"));
                btn1.Click();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(this.ToString() + " entered phone");
                Console.ResetColor();
            }
            catch
            {
                throw new SiteHTMLException(" exception with HTML");
            }

            //----------------------CAPTCHA---------------------------------

            //Thread.Sleep(5000);

            //string src = null;
            //try
            //{
            //    src = ISite.browser.FindElement(By.XPath("/html/body/overlay/div/registration/form/confirm-contact/div[1]/re-captcha/div/div/iframe")).GetAttribute("src");
            //}
            //catch { }

            //if (src != null) //если нашли капчу, то решаем
            //{
            //    try
            //    {
            //        string googleKey = src.Split(new[] { '&', '&' }, StringSplitOptions.RemoveEmptyEntries)[1];
            //        googleKey = googleKey.Substring(2);
            //        // Console.WriteLine(googleKey);

            //        WebRequest reqGET = WebRequest.Create("http://rucaptcha.com/in.php?key=5d21125ba1f7c6ecc2f3d2a3f488da6a&method=userrecaptcha&googlekey=" + googleKey + "&pageurl=https://rivegauche.ru/");
            //        WebResponse resp = reqGET.GetResponse();
            //        Stream stream = resp.GetResponseStream();
            //        StreamReader sr = new StreamReader(stream);
            //        string answer = sr.ReadToEnd();
            //        // Console.WriteLine(answer);

            //        string captchaId = "";
            //        if (answer.Contains("OK"))
            //        {
            //            captchaId = answer.Remove(0, 3);
            //        }

            //        if (captchaId != "")
            //        {
            //            Thread.Sleep(20000);
            //            string answer1 = "";
            //            do
            //            {
            //                Thread.Sleep(10000);
            //                WebRequest reqGET1 = WebRequest.Create("http://rucaptcha.com/res.php?key=5d21125ba1f7c6ecc2f3d2a3f488da6a&action=get&id=" + captchaId);
            //                WebResponse resp1 = reqGET1.GetResponse();
            //                Stream stream1 = resp1.GetResponseStream();
            //                StreamReader sr1 = new StreamReader(stream1);
            //                answer1 = sr1.ReadToEnd();
            //                //Console.WriteLine(answer1);
            //            }
            //            while (answer1 == "CAPCHA_NOT_READY");
            //            //Console.WriteLine(answer1);

            //            string answerCodeToken = answer1.Split('|', StringSplitOptions.RemoveEmptyEntries)[1];
            //            //Console.WriteLine("ИТОГ "+ answerCodeToken);

            //            ((IJavaScriptExecutor)ISite.browser).ExecuteScript("document.getElementById('g-recaptcha-response').style.removeProperty('display');");
            //            Thread.Sleep(500);

            //            ((IJavaScriptExecutor)ISite.browser).ExecuteScript("document.getElementById('g-recaptcha-response').innerHTML= '" + answerCodeToken + "'");

            //            Thread.Sleep(500);
            //            string scriptString = Properties.Resources.findRecaptchaClients.Replace("myParam1", answerCodeToken);
            //            ((IJavaScriptExecutor)ISite.browser).ExecuteScript(scriptString);

            //            Thread.Sleep(1000);
            //            IWebElement btn3 = ISite.browser.FindElement(By.XPath("/html/body/overlay/div/registration/form/confirm-contact/div[2]/button"));
            //            btn3.Click();

            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.WriteLine(this.ToString() + " solved captcha");
            //            Console.ResetColor();
            //        }
            //    }
            //    catch
            //    {
            //        throw new CaptchaErrorException(" exception while solving captcha");
            //    }
            //}
        }
    }
}
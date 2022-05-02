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
    class Labirint : ISite
    {
        public void SpamSite()
        {
            ISite.browser.Navigate().GoToUrl("https://www.labirint.ru/");
            ISite.browser.Manage().Window.Maximize();

            try
            {
                IWebElement btn = ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[5]/div[4]/div[1]/div[1]/div[2]/div/ul/li[4]/a/span[1]/span[1]/span"));
                btn.Click();
                Thread.Sleep(1000);

                ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div/div/div[1]/form[1]/div[3]/input")).SendKeys(ISite.PhoneNumberWithout7);

                IWebElement btnSend = ISite.browser.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div/div/div[1]/form[1]/input[6]"));
                btnSend.Click();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(this.ToString() + " entered phone");
                Console.ResetColor();
            }
            catch
            {
                throw new SiteHTMLException(" exception with HTML");
            }           

            //----------------------CAPTCHA---------------------------------

            Thread.Sleep(5000);
            string src = null;
            try
            {
                src = ISite.browser.FindElement(By.XPath("/html/body/div[7]/div[2]/iframe")).GetAttribute("src");
            }
            catch {  }

           
            if (src != null) //если нашли капчу, то решаем
            {
                try
                {
                    string googleKey = src.Split(new[] { '&', '&' }, StringSplitOptions.RemoveEmptyEntries)[2];
                    googleKey = googleKey.Substring(2);
                    // Console.WriteLine(googleKey);

                    WebRequest reqGET = WebRequest.Create("http://rucaptcha.com/in.php?key=5d21125ba1f7c6ecc2f3d2a3f488da6a&method=userrecaptcha&googlekey=" + googleKey + "&pageurl=https://www.labirint.ru&invisible=1");
                    WebResponse resp = reqGET.GetResponse();
                    Stream stream = resp.GetResponseStream();
                    StreamReader sr = new StreamReader(stream);
                    string answer = sr.ReadToEnd();
                    // Console.WriteLine(answer);

                    string captchaId = "";
                    if (answer.Contains("OK"))
                    {
                        captchaId = answer.Remove(0, 3);
                    }

                    if (captchaId != "")
                    {
                        Thread.Sleep(20000);
                        string answer1 = "";
                        do
                        {
                            Thread.Sleep(10000);
                            WebRequest reqGET1 = WebRequest.Create("http://rucaptcha.com/res.php?key=5d21125ba1f7c6ecc2f3d2a3f488da6a&action=get&id=" + captchaId);
                            WebResponse resp1 = reqGET1.GetResponse();
                            Stream stream1 = resp1.GetResponseStream();
                            StreamReader sr1 = new StreamReader(stream1);
                            answer1 = sr1.ReadToEnd();
                            //Console.WriteLine(answer1);
                        }
                        while (answer1 == "CAPCHA_NOT_READY");
                        //Console.WriteLine(answer1);

                        string answerCodeToken = answer1.Split('|', StringSplitOptions.RemoveEmptyEntries)[1];
                        //Console.WriteLine("ИТОГ "+ answerCodeToken);                                      

                        ((IJavaScriptExecutor)ISite.browser).ExecuteScript("document.getElementById('g-recaptcha-response').innerHTML= '" + answerCodeToken + "';");
                        //onGoogleRecapSubmit0();
                        Thread.Sleep(500);
                        ((IJavaScriptExecutor)ISite.browser).ExecuteScript("document.getElementById('auth-by-code').submit();");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(this.ToString() + " solved captcha");
                        Console.ResetColor();
                    }
                }
                catch (Exception ex)
                {
                    throw new CaptchaErrorException(this.ToString() + " exception while solving captcha");
                }
            }
            
        }
    }
}
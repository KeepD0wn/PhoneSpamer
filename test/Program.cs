using System;
using System.IO;
using System.Net.Http;
using System.Drawing;
using System.Net;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Chrome.ChromeDriverExtensions;

namespace test
{
    class Program
    {
        public static byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        public static async Task<int> Main(string[] args)
        {
            var options = new ChromeOptions();
            options.AddHttpProxy("176.103.80.227", 55603, "mRDEYNEP", "idy14sDR");
            var browser = new ChromeDriver(@"C:\Users\gvozd\Desktop", options);
            browser.Navigate().GoToUrl("https://2ip.ru/");

            

            string src = browser.FindElement(By.XPath("/html/body/div[3]/table/tbody/tr[6]/td/img[3]")).GetAttribute("src");

            WebClient downloader = new WebClient();
            downloader.DownloadFile(src, @"C:\Users\gvozd\Desktop\testImg.jpg");

            Image newImage = Image.FromFile(@"C:\Users\gvozd\Desktop\testImg.jpg");
            byte[] imgByte = ImageToByteArray(newImage);


            HttpClient httpClient = new HttpClient();
            MultipartFormDataContent form = new MultipartFormDataContent();

            form.Add(new StringContent("5d21125ba1f7c6ecc2f3d2a3f488da6a"), "key");
            form.Add(new ByteArrayContent(imgByte), "file", "captcha.jpg");
            HttpResponseMessage response = await httpClient.PostAsync("http://rucaptcha.com/in.php", form);

            response.EnsureSuccessStatusCode();
            httpClient.Dispose();
            string answer = response.Content.ReadAsStringAsync().Result;

            string captchaId = "";
            if (answer.Contains("OK"))
            {
                captchaId = answer.Remove(0, 3);
            }

            string answer1 = "";
            if (captchaId != "")
            {
                do
                {
                    Thread.Sleep(5000);
                    WebRequest reqGET1 = WebRequest.Create("http://rucaptcha.com/res.php?key=5d21125ba1f7c6ecc2f3d2a3f488da6a&action=get&id="+ captchaId);
                    WebResponse resp1 = reqGET1.GetResponse();
                    Stream stream1 = resp1.GetResponseStream();
                    StreamReader sr1 = new StreamReader(stream1);
                    answer1 = sr1.ReadToEnd();
                }
                while (answer1 == "CAPCHA_NOT_READY");
            }


            string answerCodeToken = answer1.Split('|', StringSplitOptions.RemoveEmptyEntries)[1];
            Console.WriteLine(answerCodeToken);

            Console.ReadLine();
            return 2;
        }
    }
}

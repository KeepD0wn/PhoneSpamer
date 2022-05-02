using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsSpamer
{
    interface ISite
    {
        static string PhoneNumber { get; set; }
        static string PhoneNumberWithout7 { get; set; }

        const string mail = "chustov76@gmail.com";

        static IWebDriver browser = new ChromeDriver(@"C:\Users\gvozd\Desktop");

        static string[] names = new string[] { "Михаил", "Алексей", "Александр", "Максим", "Иван", "Дмитрий", "Владимир", "Артем", "Богдан", "Андрей" };

        static string Name
        {
            get
            {
                Random rand = new Random();
                return names[rand.Next(names.Length)];
            }
        }

        void SpamSite();
    }
}

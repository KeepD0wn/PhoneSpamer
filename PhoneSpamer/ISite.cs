using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneSpamer
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

        //public const int minSpeed = 0;     // минимальная скорость
        //private static int maxSpeed = 60;

        //int MinSpeed {
        //    get => maxSpeed;
        //    set
        //    {
        //        if (value > 0) maxSpeed = value;
        //    }
        //}
        //void Move() => Console.WriteLine("Walking");
        void SpamSite();
    }
}

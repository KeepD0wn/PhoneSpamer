using OpenQA.Selenium;
using PhoneSpamerRobot.Sites;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;


namespace PhoneSpamerRobot
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

            ISite dns = new Dns();
            ISite labirint = new Labirint();
            ISite burgerKing = new BurgerKing();
            ISite cian = new Cian();
            ISite rivGosh = new RivGosh();
            ISite newtel = new NewTel();
            ISite fixprice = new FixPrice();
            ISite snowQueen = new SnowQueen();
            ISite detMir = new DetMir();

            List<ISite> sites = new List<ISite>();
            sites.Add(dns);
            sites.Add(burgerKing);
            sites.Add(rivGosh);
            //sites.Add(newtel); //не даёт регистрацию
            sites.Add(fixprice);
            sites.Add(snowQueen);
            sites.Add(detMir); // надо научится решать v2 invsible

            for (int i = 0; i < 10000; i++)
            {
                foreach (var item in sites)
                {
                    try
                    {
                        item.SpamSite();

                        Thread.Sleep(120 * 1000); // что бы цель отдохнула и отвлеклась от звонка
                        ((IJavaScriptExecutor)ISite.browser).ExecuteScript("window.open();");
                        ISite.browser.Close();
                        ISite.browser.SwitchTo().Window(ISite.browser.WindowHandles.Last());                        

                    }
                    catch (SiteHTMLException ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(item.ToString() + ex.Message);
                        Console.ResetColor();
                    }
                    catch (CaptchaErrorException ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                        Console.WriteLine(item.ToString() + ex.Message);
                        Console.ResetColor();
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                        Console.WriteLine(item.ToString()+ " "+ex.Message);     
                        Console.ResetColor();
                    }

                }
            }

            Console.WriteLine("DONE");
            Console.ReadKey();
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PhoneSpamer.Sites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace PhoneSpamer
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

            ISite uytstroi33 = new Uytstroi33();
            ISite prof33 = new Prof33();
            ISite otdelochnik33 = new Otdelochnik33();
            ISite podKluch = new PodKluch();
            ISite remontVladivostok = new RemontVladivostok();
            ISite stroyVlad = new StroyVladISite();
            ISite stroika54 = new Stroika54();
            ISite avanStroy = new AvanStroy();
            ISite sanremont = new Sanremont();
            ISite neocomfort = new Neocomfort();
            ISite stroyDom = new StroyDom();
            ISite domStroyProfi = new DomStroyProfi();
            ISite DomoDom = new DomoDom();
            ISite domotek = new Domotek();
            ISite rm27 = new Rm27();
            ISite elGrans = new ElGrans();
            ISite kit27 = new Kit27();
            ISite stroyLes27 = new StroyLes27();
            ISite dalStroy = new DalStroy();
            ISite korpM = new KorpM();
            ISite gikodv = new Gikodv();
            ISite partnerStroy = new PartnerStroy();
            ISite remontoff = new Remontoff();
            ISite stroyMaster66 = new StroyMaster66();
            ISite uralec = new Uralec();
            ISite sokora = new Sokora();
            ISite remont66 = new Remont66();
            ISite remontEKB = new RemontEKB();
            ISite artRemont = new ArtRemont();
            ISite domProfi = new DomProfi();
            ISite sdelano = new Sdelano();
            ISite indside = new Indside();
            ISite reMoscow = new ReMoscow();
            ISite fundament = new Fundament();
            ISite expressRemont = new ExpressRemont();
            ISite pik = new Pik();
            ISite studiaRemontov = new StudiaRemontov();
            ISite masteraRemonta = new MasteraRemonta();
            ISite zabStroy = new ZabStroy();
            ISite chitaEtalon = new ChitaEtalon();
            ISite dobrodom75 = new Dobrodom75();
            ISite demetra = new Demetra();
            ISite sckvashinaVlad = new SckvashinaVlad();
            ISite artemBurov = new ArtemBurov();
            ISite vladTradeService = new VladTradeService();
            ISite habBurovod = new HabBurovod();
            ISite bukVina = new BukVina();
            ISite lunet = new Lunet();
            ISite samson = new Samson();
            ISite avangard = new Avangard();

            List<ISite> sites = new List<ISite>();
            sites.Add(uytstroi33);
            sites.Add(prof33);
            sites.Add(otdelochnik33);
            sites.Add(podKluch);
            sites.Add(remontVladivostok);
            sites.Add(stroyVlad);
            sites.Add(stroika54);
            sites.Add(avanStroy);
            sites.Add(sanremont);
            sites.Add(neocomfort);
            sites.Add(stroyDom);
            sites.Add(domStroyProfi);
            sites.Add(DomoDom);
            sites.Add(domotek);
            sites.Add(rm27);
            sites.Add(elGrans);
            sites.Add(kit27);
            sites.Add(stroyLes27);
            sites.Add(dalStroy);
            sites.Add(korpM);
            sites.Add(gikodv);
            sites.Add(partnerStroy);
            sites.Add(remontoff);
            sites.Add(stroyMaster66);
            sites.Add(uralec);
            sites.Add(sokora);
            sites.Add(remont66);
            sites.Add(remontEKB);
            sites.Add(artRemont);
            sites.Add(domProfi);
            sites.Add(sdelano);
            sites.Add(indside);
            sites.Add(reMoscow);
            sites.Add(fundament);
            sites.Add(expressRemont);
            sites.Add(pik);
            sites.Add(studiaRemontov);
            sites.Add(masteraRemonta);
            sites.Add(zabStroy);
            sites.Add(chitaEtalon);
            sites.Add(dobrodom75);
            sites.Add(demetra);
            sites.Add(sckvashinaVlad);
            sites.Add(artemBurov);
            sites.Add(vladTradeService);
            sites.Add(habBurovod);
            sites.Add(bukVina);
            sites.Add(lunet);
            sites.Add(samson);
            sites.Add(avangard);

            foreach (var item in sites)
            {
                try
                {
                    item.SpamSite();
                    Thread.Sleep(5000);

                    Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
                    Console.WriteLine($"{item.ToString()}");
                    Console.ResetColor();

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
            
            Console.WriteLine("DONE");

            Console.ReadLine();
        }
    }
}

using System;
using SmsSpamer;
using PhoneSpamerRobot;
using System.Threading.Tasks;

namespace ComboSpamer
{    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер телефона с 7");
            string phoneNumber = (string)Console.ReadLine();
            string phoneNumberWithout7 = phoneNumber.Remove(0, 1);
            string[] phones = new string[] {phoneNumber,phoneNumberWithout7 };

            Console.WriteLine("Выберите вид спама: \n0 - только телефон люди \n1 - только робот телефон \n2 - только смс \n3 - смс + робот телефон");
            int chose = Convert.ToInt32(Console.ReadLine());
            switch (chose)
            {
                case 0:
                    PhoneSpamer.Program.Main(phones);
                    break;
                case 1:
                    PhoneSpamerRobot.Program.Main(phones);
                    break;
                case 2:
                    SmsSpamer.Program.Main(phones);
                    break;
                case 3:
                    Task.Factory.StartNew(() => { SmsSpamer.Program.Main(phones); });
                    PhoneSpamerRobot.Program.Main(phones);
                    break;                
            }

        }
    }
}

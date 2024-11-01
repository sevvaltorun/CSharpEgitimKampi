using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Variable:

            ////double number = 20.15;
            ////Console.WriteLine(number);

            //Console.WriteLine("***********PRICE LIST***********");
            //Console.WriteLine();

            //double applePrice, orangePrice, melonPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //melonPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("---Apple Price:" + applePrice + "₺");
            //Console.WriteLine("---Orange Price:" + orangePrice + "₺");
            //Console.WriteLine("---Melon Price:" + melonPrice + "₺");
            //Console.WriteLine("---Potato Price:" + potatoPrice + "₺");
            //Console.WriteLine("---Tomato Price:" + tomatoPrice + "₺");
            //Console.WriteLine();

            //double appleGram, orangeGram, melonGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //melonGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram =3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //Console.WriteLine("*-*-*-*-Apple Total Price:"+ appleTotalPrice + "₺");

            //double orangeTotalPrice = orangeGram * orangePrice;
            //Console.WriteLine("*-*-*-*-Orange Total Price:" + orangeTotalPrice + "₺");

            //double melonTotalPrice = melonGram * melonPrice;
            //Console.WriteLine("*-*-*-*-Melon Total Price:" + melonTotalPrice + "₺");

            //double potatoTotalPrice = potatoGram * potatoPrice;
            //Console.WriteLine("*-*-*-*-Potato Total Price:" + potatoTotalPrice + "₺");

            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //Console.WriteLine("*-*-*-*-Apple Total Price:" + tomatoTotalPrice + "₺");

            //double shoppingSumTotal;
            //shoppingSumTotal= appleTotalPrice + orangeTotalPrice + potatoTotalPrice + melonTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine("^^^^Shopping Total:" + shoppingSumTotal + "₺");
            #endregion

            #region Char Variable:
            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Input-Type String

            Console.WriteLine("***********TRN Airlines************");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            Console.Write("Passenger Name Please: ");
            passengerName = Console.ReadLine();

            Console.Write("Passenger Surname Please: ");
            passengerSurname = Console.ReadLine();

            Console.Write("Passenger District Please: ");
            passengerDistrict = Console.ReadLine();

            Console.Write("Passenger City Please: ");
            passengerCity = Console.ReadLine();

            Console.Write("Passenger Age Please: ");
            passengerAge = Console.ReadLine();

            Console.Write("Passenger Identity Number Please: ");
            passengerIdentityNumber = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Passenger Info.: " + passengerName + " " + passengerSurname);
            Console.WriteLine("Passenger Other Info.: " + passengerDistrict + "/" + passengerCity + " Age: " + passengerAge);
            Console.WriteLine("Passenger Identity Num.: " + passengerIdentityNumber);


            #endregion

            #region Input Type Int & Changing Types

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 100;
            //computerPrice = 6000;
            //chairPrice = 50;
            //tvPrice =12000;

            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Aldığınız ayakkabı miktarini giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığınız bilgisayar miktarini giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığınız sandalye miktarini giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığınız tv miktarini giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerPrice * computerCount + chairPrice * chairCount + tvPrice * tvCount;
            //Console.WriteLine();
            //Console.WriteLine(totalPrice);
            #endregion

            #region Ondalıklı Sayı İşlemleri
            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunuzu giriniz:");
            //exam1= double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunuzu giriniz:");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunuzu giriniz:");
            //exam3= double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınavlarınızın ortalaması:" + result);

            #endregion

            #region Input Type Char

            //char gender;
            //Console.WriteLine("Male: M / Female: F");
            //Console.Write("Please enter the your gander: ");
            //gender= char.Parse(Console.ReadLine());

            //Console.WriteLine( "Your Gender is: "+ gender);

            #endregion

            Console.Read();
        }
    }
}

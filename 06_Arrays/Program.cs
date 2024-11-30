using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arrays :

            //string[] colors = new string[4];
            //colors[0] = "blue";
            //colors[1] = "yellow";
            //colors[2] = "green";
            //colors[3] = "red";

            //foreach (var item in colors)
            //{
            //    Console.WriteLine(item);
            //}

            //string[] cities= new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeste";
            //cities[2] = "Lypn";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);
            //Console.WriteLine(cities[0]);
            //Console.WriteLine(cities[3]);
            //Console.WriteLine(cities[5]); hata...

            //int[] numbers = new int[10];
            //numbers[0] = 12;
            //numbers[1] = 112;
            //numbers[6] = 26;
            //numbers[4] = 286;
            //Console.WriteLine(numbers[7]); //default değeri 0 gelir 


            //string[] cities = { "kocaeli", "istanbul", "ankara", "eskisehir", "antalya" };
            //Console.WriteLine(cities[2]);
            //Console.WriteLine(cities[0]);
            #endregion

            #region List All Elements in The Array:
            //string[] colors = { "yellow", "green", "purple", "white", "red"};

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 3,1,34,41,11,35,77,81,7,9};
            //for (int i = 0; i <numbers.Length; i++)
            //{
            //    if (numbers[i] %3 == 0) 
            //        Console.WriteLine("divided by 3: "+numbers[i]);
            //}

            //char[] symbols = { 's', 't', 'b', 'c', 'i' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] numbers = { 1, 21, 33, 4, 5, 6, 7, 8, 9, 310, 11, 102, 193, 14 };
            //int maxNumber=numbers[0];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > maxNumber)
            //    {
            //        maxNumber = numbers[i];
            //    }

            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "ali", "cem", "can", "nil", "su"};
            //Console.WriteLine(persons.Length);

            //SIRALI YAZAR 
            //int[] numbers = { 1, 2, 5, 78, 333, 1023, 22, 7 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //KOMPLE DİZİYİ tersten sıralar
            //int[] numbers = { 1, 2, 5, 78, 333, 1023, 22, 7 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region Methods:

            //string[] customer = { "deniz", "cınar", "toprak", "su", "güneş" };

            //int index = Array.IndexOf(customer, "su");
            //Console.WriteLine(index);

            //int[] numbers = { 12, 45, 67, 89, 23, 46, 12, 1 };
            //Console.WriteLine("Max Number: " + numbers.Max());
            //Console.WriteLine("Min Number: " + numbers.Min());



            #endregion

            #region Input From Users:

            //string[] cities = new string[3];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Please enter the {i+1} city name: ");
            //    cities[i] =Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 1, 2, 3,  4, 5, 6, 7 };

            //int sum = 0;

            //for (int i = 0; i <numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);
            //int[] numbers = { 11, 21, 36, 46, 56, 586, 87, 98, 99, 100 };

            //Console.WriteLine("Double Numbers: ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("--------------------------------------");

            //Console.WriteLine("Single Numbers: ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            #endregion
            Console.Read();
        }
    }
}

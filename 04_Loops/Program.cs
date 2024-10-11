using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Loops:

            //for (int i = 0; i <10; i++)
            //{
            //    Console.WriteLine("Number: "+ i);
            //}

            //for (int i = 3; i <= 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Please enter the what do u want to finish value? ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 0; i <=finishValue; i++)
            //{
            //    Console.WriteLine(i);
            //}



            #endregion

            #region Decision St. with For Loops:

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 ==0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //int sum = 0;
            //for (int i = 0; i <=10; i++) {
            //    sum += i;
            //}

            //Console.WriteLine(sum);

            //int coupleTotal=0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        coupleTotal += i;
            //    }
            //}
            //Console.WriteLine("1 AND 10 couple numbers sum: " + coupleTotal);

            //int number;

            //for (int i = 0; i <=50; i++)
            //{
            //    if (i % 7 ==0)
            //    {
            //        number=+ i;
            //        Console.WriteLine(number);

            //    }
            //}

            //int bacteria = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacteria *= 2;
            //    Console.WriteLine(i + ".st after number of bacteria: " + bacteria);
            //}

            #endregion

            #region While Loops:

            //while(decision)
            //{
            //Process(islemler)
            //}


            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("hi "+i);
            //    i++;
            //}


            //int i = 1;
            //while (i <= 15)
            //{
            //    if (i % 3 == 0) 
            //    {
            //        Console.WriteLine("Number: " + i);
            //        i++;
            //    }
            //    Console.WriteLine("Not: " + i);
            //    i++;
            //}

            //int i = 1;
            //int summary = 0;
            //while (i <= 10)
            //{
            //  Console.WriteLine(" NEW SUM:" + summary);
            //    summary += i;
            //    i++;
            //}
            #endregion

            #region Example for Loops:
            //289
            //sum of 3-digit numbers entered from the keyboard:

            //int number;

            //Console.Write("Please enter the number: ");
            //number = int.Parse(Console.ReadLine());

            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10; //ones true
            //tens = (number % 100)/10 ; // 
            //hundreds = number / 100; // true

            //Console.WriteLine("Ones: " + ones);
            //Console.WriteLine("Tens:" + tens);
            //Console.WriteLine("Hundreds: " + hundreds);
            //sum= ones + tens + hundreds;
            
            //Console.WriteLine("SUM OF DIGITS: " +sum);
            #endregion

            Console.Read();
        }
    }
}

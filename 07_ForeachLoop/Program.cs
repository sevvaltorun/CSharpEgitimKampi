using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Loops:
            //FOREACH SADECE DİZİLERLE DEĞİL LİSTELERLE DE ÇALIŞIR

            //string[] name = { "sevval", "burak","ali","nisa"};

            //foreach (var isim in name)
            //{
            //    Console.WriteLine(isim);
            //}

            //int[] ages = { 11, 22, 23, 43, 56, 98, 89, 456, 201, 220 };

            //Console.WriteLine("Double Numbers");
            //foreach (var item in ages)
            //{
            //    if (item % 2 == 0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //Console.WriteLine("------------------------------");

            //Console.WriteLine("Single Numbers");
            //foreach (var item in ages)
            //{
            //    if (item % 2 == 1)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}


            //int sum = 0;
            //foreach (var item in ages)
            //{
            //    sum += item;
            //}

            //Console.WriteLine("ages summary= " + sum);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};
            // Console.WriteLine(numbers); //metinsel ifade döndürüyor
            //System.Collections.Generic.List`1[System.Int32]

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("List in double num. ");

            //foreach (int i in numbers)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //string word = "sevval";
            //foreach (char c in word)
            //{
            //    Console.Write(" " +c);
            //}


            #endregion

            #region Example Application:
            //klavyeden öğrenci adı ve sayısı al sımav notlarını allaım be ortalama hesaplayalım 

            Console.WriteLine("*****C# Bootcamp Exam Application*****");

            int sumStudent;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("How many students are in your class? ");
            Console.Write("Please enter: ");
            sumStudent = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------");

            string[] studentNames = new string[sumStudent];
            double[] studentExamAvg = new double[sumStudent];



            for (int i = 0; i < sumStudent; i++)
            {
                Console.Write($"{i + 1} .th Student's name please: ");
                studentNames[i] = Console.ReadLine();
                Console.WriteLine("----------------------------------------------");

                double totalExamResult = 0;

                //student's have 3 exams!!!
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Please enter the {studentNames[i]} student named {j + 1} . exam result: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }
                Console.WriteLine("----------------------------------------------");
                studentExamAvg[i] = totalExamResult / 3;
            }

            //EXAM AVG:
            for (int i = 0; i < sumStudent; i++)
            {
                Console.WriteLine($"{studentNames[i]} student named exam avg:{studentExamAvg[i]}");
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"DEAR {studentNames[i]},you have successfully passed the exam!");
                }
                else
                {
                    Console.WriteLine($"DEAR {studentNames[i]} , you have failed and stayed the exam!");
                }

            }


            #endregion

            Console.Read();
        }
    }
}

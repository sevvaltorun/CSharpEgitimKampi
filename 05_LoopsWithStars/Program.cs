using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 10 Stars in a Row/Side by Side:
            //int i = 0;
            //while(i<=10)
            //{
            //    Console.WriteLine("*");
            //    i++;
            //}


            // 10 Stars Side by Side:
            //int i = 0;
            //while (i <= 10)
            //{
            //    Console.Write("*");
            //    i++;
            //}

            #endregion

            #region Dik üçgen/Ters Üçgen/Bakla Dilimi:

            //int i =1;
            //int j = 1;

            //for (i = 1; i <=5; i++)
            //{
            //    for (j=1; j<=2; j++)
            //    {
            //        Console.WriteLine("*");
            //    }
            //    Console.WriteLine();
            //}


            //int i = 1;
            //int j = 1;

            //for (i = 1; i <= 5; i++)
            //{
            //    for (j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //ters dik üçgen

            //for (int i = 5; i>=1 ; i--)
            //{
            //    for (int j = 1; j<= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            // ters ve dik üçgen birlikte:
            //for (int i = 0; i <= 5; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int k = 4; k >= 1; k--)
            //{
            //    for (int m = 0; m <= k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //int n = 5;
            //for (int i = 1; i <=n; i++)
            //{
            //    for (int j = n-1;j>0 ; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k=1; k<=2*i-1;k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i =n-1; i>=1 ; i--)
            //{
            //    for (int j= n-1; j >0;  j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k =1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();  
            //}
            #endregion

            #region Piramit

            //int n = 5;
            //for (int i = 1; i <=n; i++)
            //{
            //    //blanks
            //    for (int j=n-i; j>0;j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    //stars
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Piramit
            //int n = 5;
            //for (int i = n; i >= 1; i--)
            //{
            //    //bosluklar
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    //stars
            //    for(int k=1; k<=2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            Console.Read();

        }
    }
}

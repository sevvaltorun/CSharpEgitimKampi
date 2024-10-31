using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region IF:
            // be careful!
            //int age;
            //Console.Write("Please enter the number");
            //age = int.Parse(Console.ReadLine()); 


            //string password;
            //Console.Write("Please enter the password: ");
            //password = Console.ReadLine();

            //if (password == "sevval")
            //{
            //    Console.WriteLine("Password is TRUE");
            //}

            //else 
            //{
            //    Console.WriteLine("Password is FALSE");
            //}

            //string province, country;
            //Console.Write("Please enter the capital: ");
            //province= Console.ReadLine();

            //Console.Write("Please enter the country: ");
            //country = Console.ReadLine();

            //if(province == "kocaeli" && country=="türkiye")
            //{
            //    Console.WriteLine("u're living in kocaeli/türkiye");
            //}

            //else
            //{
            //    Console.WriteLine("u're not living in kocaeli/türkiye");
            //}

            //int number;
            //Console.Write("Please enter the number");
            //number= int.Parse(Console.ReadLine());

            //if(number == 22)
            //{
            //    Console.WriteLine("true, number is 22");
            //}

            //else
            //{
            //   Console.WriteLine("false, number isn't 22");
            //}

            //int exam1, exam2, exam3;

            //Console.Write("Please enter the exam 1 mark: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Please enter the exam 2 mark: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Please enter the exam 3 mark: ");
            //exam3 = int.Parse(Console.ReadLine());


            //double average = (exam1 + exam2 + exam3) / 3;

            //if (average == 0) 
            //{
            //    Console.WriteLine("Average: " + average + " it's so bad so, u'll study hard..");
            //}
            //else if (average < 50)
            //{
            //    Console.WriteLine("Average: " + average + " it's developing so u'll study");
            //}
            //else if (average>=50 )
            //{
            //   Console.WriteLine("Average: " + average + " it's good average but u'll study");
            //}
            //else if(average==100)
            //{
            //    Console.WriteLine("Average: " + average + " Congrats!");
            //}
            //else
            //{
            //    Console.WriteLine("Average: " + average + " it's declared");
            //}

            //Console.Write("Please enter the admin: ");
            //string admin = Console.ReadLine();

            //if (admin != "sevval")
            //{
            //    Console.WriteLine("false admin name");
            //}

            //else
            //{
            //    Console.WriteLine("welcome " + admin);
            //}

            //Console.Write("Bir karakter giriniz: ");
            //char ch = char.Parse(Console.ReadLine());

            //if (Char.IsUpper(ch))
            //{
            //    Console.WriteLine("Girilen karakter büyük bir karakterdir!");
            //}
            //else if (Char.IsLower(ch))
            //{
            //    Console.WriteLine("Girilen karakter küçük bir karakter!");
            //}
            //else if (Char.IsDigit(ch))
            //{
            //    Console.WriteLine("Girilen karakter bir rakamdır!");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen karakter alfanumerik bir ifade değildir!");
            //}


            #endregion

            #region Mod:

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine("Number: " + number + " MOD: " +result);

            //Console.Write("Enter the first number to find the remainder:");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the second number to find the remainder:");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine( number1 + " / " + number2 + " result is : " + result);

            //Console.Write("Please enter the number divided by 2: ");
            //int number = int.Parse(Console.ReadLine());

            //int result = number % 2;

            //if (result == 0)
            //{
            //    Console.WriteLine(number + " is " + " double ");
            //}
            //else
            //{ 
            //    Console.WriteLine(number + " is " + " single ");
            //}

            #endregion

            #region Decision structures with char var.:
            //char team;

            //Console.Write("Please enter the your team char/symbol:");
            //team= Char.Parse(Console.ReadLine());

            //if (team == 'F' || team == 'f')
            //{
            //    Console.WriteLine("your team name is FENERBAHCE");
            //}
            //else if (team == 'G' || team == 'g')
            //{
            //    Console.WriteLine("your team name is GALATASARAY");
            //}
            //else if (team == 'B' || team == 'b')
            //{
            //    Console.WriteLine("your team name is BESİKTAS");
            //}
            //else 
            //{
            //    Console.WriteLine("undefined");
            //}
            #endregion

            #region Example Poject App.:
            //Console.WriteLine("*****MENU*****");
            //Console.WriteLine();
            //Console.WriteLine("1-Main Meals");   
            //Console.WriteLine("2-Pizzas");   
            //Console.WriteLine("3-Drinks");   
            //Console.WriteLine("4-Desserts");
            //Console.WriteLine("****************");

            //int menuItems;
            //Console.Write("Please enter the your decisions for detail: ");
            //menuItems =int.Parse(Console.ReadLine());

            //switch (menuItems)
            //{
            //    case 1:
            //        Console.WriteLine("-----------------------");
            //        Console.WriteLine("1->Pasta");
            //        Console.WriteLine("2->Nuget");
            //        Console.WriteLine("3->Chicken Wrap");
            //        Console.WriteLine("-----------------------");
            //        break;

            //    case 2:
            //        Console.WriteLine("-----------------------");
            //        Console.WriteLine("1->Piiza with cheese");
            //        Console.WriteLine("2->Piiza with chicken");
            //        Console.WriteLine("3->Piiza with olive");
            //        Console.WriteLine("4->Piiza with tomato");
            //        Console.WriteLine("-----------------------");
            //        break;
            //    case 3:
            //        Console.WriteLine("-----------------------");
            //        Console.WriteLine("1->Cola");
            //        Console.WriteLine("2->Fanta");
            //        Console.WriteLine("3->Apple Juice");
            //        Console.WriteLine("4->Orange Juice");
            //        Console.WriteLine("5->Peach Juice");
            //        Console.WriteLine("-----------------------");
            //        break;

            //        case 4:
            //        Console.WriteLine("-----------------------");
            //        Console.WriteLine("1-Magnolia");
            //        Console.WriteLine("2-Cake");
            //        Console.WriteLine("3-Ice Cream");
            //        Console.WriteLine("4-Waffle");
            //        Console.WriteLine("5-Waffle with Ice Cream");
            //        Console.WriteLine("6-Muffin");
            //        Console.WriteLine("-----------------------");
            //        break;

            //    default:
            //        break;
            //}


            #endregion

            #region Switch Case:

            //Console.Write("Please enter the number of month: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("January");
            //        break;
            //    case 2:
            //        Console.WriteLine("February");
            //        break;
            //    case 3:
            //        Console.WriteLine("March");
            //        break;
            //    case 4:
            //        Console.WriteLine("April");
            //        break;
            //    case 5:
            //        Console.WriteLine("May");
            //        break;
            //    case 6:
            //        Console.WriteLine("June");
            //        break;
            //    case 7:
            //        Console.WriteLine("July");
            //        break;
            //    case 8:
            //        Console.WriteLine("August");
            //        break;
            //    case 9:
            //        Console.WriteLine("September");
            //        break;
            //    case 10:
            //        Console.WriteLine("October");
            //        break;
            //    case 11:
            //        Console.WriteLine("November");
            //        break;
            //    case 12:
            //        Console.WriteLine("December");
            //        break;

            //    default:
            //        Console.WriteLine("UNDEFINED"); 
            //        break;

            #endregion

            #region Calculator with Switch Case:

            //int number1, number2, result;
            //char symbol;

            //Console.Write("Please enter the number 1: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("Please enter the number 2: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter to making to do process: ");
            //symbol = char.Parse(Console.ReadLine());


            //switch(symbol)
            //{
            //    case '+': 
            //        result = number1+ number2;
            //        Console.WriteLine("Result: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Result: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Result: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Result: " + result);
            //        break;
            //    default: Console.WriteLine("Your Numbers are: " + number1 + " and " + number2 + " but symbol is undefined"); break;
            //}
            #endregion

            Console.Read();

        }
    }
}

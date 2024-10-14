using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Hello Word:
            //Console.WriteLine("Hello Word again...");
            //Console.Write("28.09");
          
            #endregion

            #region Variables:

            //string name = "sevval";
            ////Console.WriteLine(name);
            //string surname;
            ////same property
            //surname = "torun";
            ////Console.WriteLine(surname);

            //string phoneNumber, city, email;
            //phoneNumber = "+901234567890";
            //city = "Kocaeli";
            //email = "sevval@st.com";
            ////Console.WriteLine(phoneNumber);
            ////Console.WriteLine(city);
            ////Console.WriteLine(email);

            //Console.Write("Kişi Bilgileri:");
            //Console.WriteLine(name + surname);
            //Console.WriteLine("Telefon Numarası: " + phoneNumber );
            //Console.WriteLine("E-Mail Adresi: " + email);
            //Console.WriteLine("Yasadıgı Sehir: " + city);

            //name = "ceyda";
            //Console.WriteLine(name);



            #endregion

            #region Int Variable:

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 70;

            Console.WriteLine("*******MENU*******");
            Console.WriteLine("Hamburger Price->" + hamburgerPrice);
            Console.WriteLine("Coke Price->" + cokePrice);
            Console.WriteLine("Water Price->" + waterPrice);
            Console.WriteLine("Fries Price->" + friesPrice);
            Console.WriteLine("Pizza Price->" + pizzaPrice);
            Console.WriteLine("Lemonade Price->" + lemonadePrice);

            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;  
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalWaterPrice = 0;
            int totalCokePrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;

            hamburgerCount = 3;
            waterCount = 3;
            cokeCount = 3;
            friesCount=1;
            pizzaCount = 0;
            lemonadeCount=0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalWaterPrice = waterCount * waterPrice;
            totalCokePrice= cokeCount * cokePrice;  
            totalFriesPrice= friesCount * friesPrice;
            totalPizzaPrice= pizzaCount * pizzaPrice;   
            totalLemonadePrice= lemonadeCount * lemonadePrice;


            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Hamburger Total Price:" + totalHamburgerPrice + "TL");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Water Total Price:" + totalWaterPrice + "TL");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Coke Total Price:" + totalCokePrice + "TL");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Fries Total Price:" + totalFriesPrice + "TL");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Pizza Total Price:" + totalPizzaPrice + "TL");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Lemonade Total Price:" + totalLemonadePrice + "TL");
            Console.WriteLine("******************************************************************************");

            int sumTotalPrice = totalLemonadePrice + totalPizzaPrice + totalFriesPrice + totalCokePrice + totalWaterPrice + totalHamburgerPrice;
            Console.WriteLine("Summary Total:"+ sumTotalPrice);

            //end of the first day
            #endregion


            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Methods:

            /* () and purple cube
             * Geriye değer döndürmeyen Metotlar
             * belirli işler için kod tekrarını önleyen yapılardır
             * Customer--> Listele, Ekle, Sil, Güncelle
            */


            //void CustomerList()
            //{
            //    Console.WriteLine("Sevval Torun");
            //    Console.WriteLine("Ceyda Torun");
            //    Console.WriteLine("Nisasu Torun");
            //    Console.WriteLine("Inci Torun");
            //}

            //Console.WriteLine("In List :");
            //CustomerList();


            //void Sum()
            //{
            //    int x = 2;
            //    int y = 3;
            //    int z = x + y;

            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region Geriye Deger Döndürmeyen String Parametreli Metotlar:

            //void WriteMethod(string customerName)
            //{

            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("ALI BBS");


            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Dear Customer," + name + " " + surName);
            //}
            //CustomerCard("sevval","yıldız");
            //CustomerCard("ceyda","yıldız");
            //CustomerCard("inci","yıldız");


            #endregion

            #region Geriye Deger Döndürmeyen Int Parametreli Metotlar:

            //void Sum(int n1, int n2, int n3)
            //{
            //    int result = n1 + n2 + n3;
            //    Console.WriteLine(result);
            //}
            //Sum(5,8,3);

            #endregion

            #region Geriye Deger Döndüren Metotlar:

            //string CustomerName()
            //{
            //    return "sevval inci";
            //}

            //CustomerName();


            //string StudentCard()
            //{
            //    string name = "inci";
            //    string surname = "torun";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Deger Döndüren String Parametreli Metotlar:

            //string CountryCard( string countryName, string capitalName, string flagColor )
            //{
            //    string cardInfo ="Country Name: "+ countryName+ " Capital Name: " + capitalName + " Color/s of Flag: " + flagColor;
            //    return cardInfo;
            //}

            //string country, capital, flag;
            //Console.Write("Please enter the your country name :");
            //country = Console.ReadLine();

            //Console.Write("Please enter the your capital name :");
            //capital = Console.ReadLine();

            //Console.Write("Please enter the your flag color :");
            //flag = Console.ReadLine();

            //Console.WriteLine(CountryCard(country,capital,flag));
            //Console.WriteLine(CountryCard("Japan","Tokyo","red and white"));
            //Console.WriteLine(CountryCard("Italy","Roma","white, red and green"));
            #endregion

            #region Geriye Deger Döndüren Int Parametreli Metotlar:

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;  
            //}
            //Console.WriteLine(Sum(12,8));
            //Console.WriteLine(Sum(21,12));
            //Console.WriteLine(Sum(100,18));


            #endregion

            #region Example:
            //bool ExamResult(string studentName, int examNote)
            //{
            //    double result = examNote / 3;

            //    if (result >= 50)
            //    {
            //        return true;
            //       // Console.WriteLine($"Congs dear {studentName}!You passed the exam!");
            //    }
            //    else
            //    {
            //        return false;
            //        // Console.WriteLine($"Dear {studentName} !You don't passed the exam! Please try again");
            //    }
            //}

            string ExamResult(string studentName, int examNote)
            {
                double result = examNote / 3;

                if (result >= 50)
                {
                    return $"Congs dear {studentName}! You passed the exam!" + $"AVG: {result}";
                }
                else
                {
                    return $"Dear {studentName} !You don't passed the exam! Please try again" + $"AVG: {result}";
                }
            }

            string student;
            int note = 0;

            Console.Write("Please enter the student name: ");
            student = Console.ReadLine();

            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Please enter the {i}. exam result: ");
                note += int.Parse(Console.ReadLine());
            }

            Console.WriteLine(ExamResult(student, note));
            //sen aşağıdaki gibi yazarak ekleyemezsin ama çünkü exam1, exam2 şeklinde yazmadın 
            // Console.WriteLine(ExamResult("ayse", 80));

            #endregion

            Console.Read();
        }
    }
}

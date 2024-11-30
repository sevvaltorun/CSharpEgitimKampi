using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRUD işlemleri gerçekleştireceğiz

            Console.WriteLine("***** Menu Order Panel*****");
            Console.WriteLine();

            #region Add to Category Process
            //Console.WriteLine("------------------------");
            //Console.Write("Enter the want to add category name: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source = LAPTOP-QNO3SB5P\\SQLEXPRESS; initial Catalog = EgitimKampiDb; integrated security = true; ");

            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Added Category with successfully!");
            //Console.WriteLine();
            //Console.WriteLine();

            #endregion

            #region Add to Product Process
            //Console.WriteLine("------------------------");
            //Console.Write("Enter the want to add product name: ");
            //string productName = Console.ReadLine();

            //Console.Write("Enter the want to add product price: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            ////Console.Write("Enter the want to add product status: ");
            ////bool productStatus= bool.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = LAPTOP-QNO3SB5P\\SQLEXPRESS; initial Catalog = EgitimKampiDb; integrated security = true;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Product added with successfully!!!");

            #endregion

            #region List of Product

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-QNO3SB5P\\SQLEXPRESS; initial Catalog=EgitimKampiDb; integrated Security=true;");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}
            //connection.Close();


            #endregion

            #region Delete to Product

            //Console.Write("Please enter the delete id of product: ");
            //int productId =int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-QNO3SB5P\\SQLEXPRESS; initial Catalog=EgitimKampiDb; integrated Security=true;");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete from TblProduct where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.WriteLine("Product deleted with successfully!!!");

            #endregion

            #region Update to Product

            //Console.Write("Enter the update to Product Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Enter the update to Product Name: ");
            //string productName = Console.ReadLine();

            //Console.Write("Enter the update to Product Price: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-QNO3SB5P\\SQLEXPRESS; initial Catalog=EgitimKampiDb; integrated Security=true;");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName," +
            //    "ProductPrice=@productPrice where ProductId=@productId", connection);

            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productPrice",productPrice);
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Product updated with successfully!!!");



            #endregion


            Console.Read();
        }
    }
}

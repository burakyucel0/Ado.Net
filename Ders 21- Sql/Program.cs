using Ders_21__Sql.Manager;
using System;
using System.Data.SqlClient;

namespace Ders_21__Sql
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string connectionString = "Server = localhost\\SQLEXPRESS; Database = Northwind; Trusted_Connection = True";

            //SqlConnection sqlConnection = new SqlConnection(connectionString);

            //SqlCommand cmd = new SqlCommand("select * from Products", sqlConnection);

            //sqlConnection.Open();
            //var result = cmd.ExecuteReader();
            //while (result.Read())
            //{
            //    Console.WriteLine(result["ProductName"]);
            //}

            //sqlConnection.Close();



            ProductManager productManager = new ProductManager();


            var products = productManager.GetAllProducts();



            //Console.WriteLine("Lütfen maximum değeri giriniz.");

            //decimal max =Convert.ToDecimal(Console.ReadLine());

            //Console.WriteLine("Lütfen min değeri giriniz.");

            //decimal min = Convert.ToDecimal(Console.ReadLine());

            //var products1 = productManager.GetPriceBetweenProducts(max,min);

            var products2 = productManager.GetZeroStockProducts();

            Console.WriteLine("Lütfen bir isim giriniz");

            string name = Console.ReadLine();

            var products3 = productManager.GetNameProducts(name);



            SupplierManager supplierManager = new SupplierManager();

            var suppliers = supplierManager.GetAllSuppliers();






       
            

        }
    }
}

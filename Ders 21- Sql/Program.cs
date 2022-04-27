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

            //1) Dışarıdan decimal minimum ve maximum price alan ve onlara uygun ürünleri bana dönen metot.
            #region Soru1 
            //Console.WriteLine("Lütfen maximum değeri giriniz.");

            //decimal max =Convert.ToDecimal(Console.ReadLine());

            //Console.WriteLine("Lütfen min değeri giriniz.");

            //decimal min = Convert.ToDecimal(Console.ReadLine());

            //var products1 = productManager.GetPriceBetweenProducts(max,min);
            #endregion




            
            
            

            //2) Stokta olmayan(stok sayısı 0) olan ürünleri bana dönen metot.
            #region Soru 2
            var products2 = productManager.GetZeroStockProducts();
            #endregion


            //3) Dışarıdan name alan ve aldığı name değerindeki ürünleri arayıp bana dönen metot.
            #region Soru 3
            //Console.WriteLine("Lütfen bir isim giriniz");

            //string name = Console.ReadLine();

            //var products3 = productManager.GetNameProducts(name);
            #endregion

            //4) Ürünlerin ortalama fiyatını bana veren metot.
            #region Soru 4
            var product4 = productManager.GetPriceAVG();
            #endregion

            //5) Dışarıdan CategoryId alan ve o categoryId e ait ürünlerin ortalama fiyatını bana dönen metot.
            #region Soru 5
            //Console.WriteLine("Lütfen kategori id'si giriniz");

            //int id = Convert.ToInt32( Console.ReadLine());

            //var product5 = productManager.GetCategoryAVG(id);
            #endregion



            #region Suppliers
            SupplierManager supplierManager = new SupplierManager();

            var suppliers = supplierManager.GetAllSuppliers();
            #endregion


        }
    }
}

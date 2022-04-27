using Ders_21__Sql.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ders_21__Sql.Env;
using System.Data.SqlClient;

namespace Ders_21__Sql.Manager
{
    public class SupplierManager
    {
        public List<Suppliers> GetAllSuppliers()
        {
            List<Suppliers> suppliers = new List<Suppliers>();

            using(SqlConnection sqlConnection = new SqlConnection(Connection.connectionString))
            {
                try
                {
                    sqlConnection.Open();

                    SqlCommand cmd = new SqlCommand("select * from Suppliers", sqlConnection);

                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Suppliers supplier = new Suppliers();

                        supplier.Id =Convert.ToInt32(reader["SupplierID"]);
                        supplier.CompanyName = reader["CompanyName"].ToString();
                        supplier.ContactName = reader["ContactName"].ToString();
                        supplier.ContactTitle = reader["ContactTitle"].ToString();

                        suppliers.Add(supplier);
                    }

                    sqlConnection.Close();

                    return suppliers;
                }
                catch
                {

                    return suppliers;
                }
            }
          


            return new List<Suppliers>();
        }


    }
}

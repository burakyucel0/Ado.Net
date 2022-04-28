using Ders_21__Sql.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_21__Sql.Manager
{
    public class OrderManager
    {
        public SingletonDBConnection singletonDBConnection;

        public OrderManager()
        {
            singletonDBConnection = SingletonDBConnection.getDbInstance();
        }

        public List<Order> GetAllOrder()
        {
            List<Order> orders = new List<Order>();

            SqlConnection sqlConnection = singletonDBConnection.GetDbConnection();

            SqlCommand cmd = new SqlCommand("select * from Orders", sqlConnection);

            var reader = cmd.ExecuteReader();


            while (reader.Read())
            {

                Order order = new Order();

                order.OrderId =Convert.ToInt32(reader["OrderID"]);
                order.EmployeeId = Convert.ToInt32(reader["EmployeeID"]);
                order.OrderDate= Convert.ToDateTime(reader["OrderDate"]);
                order.RequiredDate= Convert.ToDateTime(reader["RequiredDate"]);
                order.Freight = Convert.ToDecimal(reader["Freight"]);
                order.ShipCity = reader["ShipCity"].ToString();
                order.ShipCounty = reader["ShipCountry"].ToString();

                orders.Add(order);
            }

            sqlConnection.Close();


            return orders;



        }

              



            
        
    }
}

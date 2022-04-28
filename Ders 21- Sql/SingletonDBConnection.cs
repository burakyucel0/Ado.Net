using Ders_21__Sql.Env;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_21__Sql
{
    public class SingletonDBConnection
    {
        private static SingletonDBConnection dbInstance;

        private readonly SqlConnection sqlConnection = new SqlConnection(Connection.connectionString);


        private SingletonDBConnection()
        {

        }

        public static SingletonDBConnection getDbInstance()
        {
            if (dbInstance == null)
            {
                dbInstance = new SingletonDBConnection();
            }

            return dbInstance;
        }



        public SqlConnection GetDbConnection()
        {
            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {

            }

            return sqlConnection;
        }


    }
}

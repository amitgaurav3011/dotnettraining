using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SqlAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString;
            SqlConnection connection;
            connectionString = @"Data Source=DESKTOP-QS5GLOC\SQLEXPRESS;Initial Catalog=HRDB;Integrated Security=true";
            connection = new SqlConnection(connectionString);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();

            string sql = "select * from countries";

            try
            {
                connection.Open();
                SqlCommand SqlCmd = new SqlCommand(sql, connection);

                adapter.SelectCommand = SqlCmd;

                adapter.Fill(ds);

                foreach(DataRow dr in ds.Tables[0].Rows) 
                {
                    Console.WriteLine(dr.ItemArray[0] + "---" + dr.ItemArray[1]+"---"+dr.ItemArray[2]);
                }

                SqlCmd.Dispose();

                 
            }
            catch(Exception ex)
            {
                Console.WriteLine("Can not open connection!");
            }
            finally{
                adapter.Dispose();
               
               connection.Close();
            }

            Console.ReadKey();

        }
    }
}

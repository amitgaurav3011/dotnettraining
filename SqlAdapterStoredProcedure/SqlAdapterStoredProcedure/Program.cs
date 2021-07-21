using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SqlAdapterStoredProcedure
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString;
            connectionString = @"Data Source=DESKTOP-QS5GLOC\SQLEXPRESS;Initial Catalog=HRDB;Integrated Security=true";

            SqlConnection connection = new SqlConnection(connectionString);

            DataSet ds = new DataSet();

            string sql = "Select * from regions";

            //SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                connection.Open();
                da.SelectCommand = new SqlCommand(sql, connection);
                da.SelectCommand.CommandType = CommandType.Text;
               // da.SelectCommand.Parameters.AddWithValue("@OrderId", 1);
                da.Fill(ds);

                foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    Console.WriteLine(dr.ItemArray[0]);
                }


            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                da.Dispose();
                connection.Close();
            }

            Console.ReadLine();


        }
    }
}

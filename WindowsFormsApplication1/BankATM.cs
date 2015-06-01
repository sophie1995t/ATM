using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ATM_Windows_Application
{
    class BankATM
    {
        static void Main1()
        {
            SqlConnection conn = new SqlConnection(
                "Data Source=STUDENT14\\SQLEXPRESS;Initial Catalog=BankATM;Integrated Security=SSPI");
            
            SqlDataReader rdr = null;

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select * from Customers", conn);

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0]);
                }
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }

                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}

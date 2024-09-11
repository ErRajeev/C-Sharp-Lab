using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    public static void Main()
    {
        string connectionString = "Data Source=PIKACHU;Initial Catalog=rajeev;Integrated Security=True";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string sql = "SELECT * FROM employee";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "employee");
            // Work with the data in dataSet
           while(dataSet!=null)
            {
                Console.WriteLine(dataSet.);
            }
            
        }
        // Database connection is closed; work with data offline.
    }
}

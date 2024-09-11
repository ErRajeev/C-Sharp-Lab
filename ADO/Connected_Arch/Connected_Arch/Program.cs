using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    public static void Main()
    {
        string connectionString = @"Data Source=PIKACHU;Initial Catalog=rajeev;Integrated Security=True";
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open();
            string sql = "SELECT * FROM employee";
            using (SqlCommand command = new SqlCommand(sql, con))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.Write(reader["id"]+" ");
                    Console.Write(reader["name"]+" ");
                    Console.WriteLine(reader["email"] + "\n");
                }
            }
        }
    }
}

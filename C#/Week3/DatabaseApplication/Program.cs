using Microsoft.Data.SqlClient;
namespace DatabaseApplication
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string CONN_STRING = "Data Source=5CG9445SKD;Initial Catalog=test;Integrated Security=True;Encrypt=False;";
            SqlConnection conn = new SqlConnection(CONN_STRING);

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from Employee;";

            SqlDataReader reader = cmd.ExecuteReader();
            
            
            while (reader.Read())
                    {
                
                Console.WriteLine(reader.Read());
                Console.WriteLine(reader.GetString(1));
                Console.WriteLine(reader.GetString(2));
                Console.WriteLine(reader.GetString(3));
                Console.WriteLine(reader.GetDecimal(4));
                Console.WriteLine();
                }

            conn.Close();
            
        }
        }
    }
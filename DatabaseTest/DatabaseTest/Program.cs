using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest
{
    class Program
    {   
        public static string CreateObjectID()
        {
            Random rand = new Random();
            int rand_num = rand.Next(0, 10);
            string rand_str = rand_num.ToString();

            for(int i = 0; i < 12; i++)
            {
                rand_str += rand_num.ToString();
            }

            return rand_str;
        }

        public static SqlConnection ConnectToDatabase()
        {
            string connectionString = @"Data Source=ARL1WK-01733;Initial Catalog=Testing;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                Console.WriteLine("Connected to Database");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Something went wrong with exeption: " + ex.Message.ToString());
            }
            return conn;
        }

        public static void InitializeDatabase(SqlConnection conn, SqlCommand command, string sql)
        {
            try
            {
                // Create Schema Query
                sql = "CREATE SCHEMA Profiles";
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                Console.WriteLine("Created Profiles Schema");

                // Create Table Query (Clients)
                sql = "CREATE TABLE Clients (client_id INT PRIMARY KEY, name VARCHAR(100), email VARCHAR(100), phone VARCHAR(100), funds INT)";
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                Console.WriteLine("Created Clients Table");

                // Create Table Query (Investment Firms)
                sql = "CREATE TABLE Firms (firm_id INT PRIMARY KEY, client_id INT, firm VARCHAR(100), num_clients INT, market_value INT, year INT, ceo varchar(100))";
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                Console.WriteLine("Created Firms Table");

                // Create Table Query (Invement Products)
                sql = "CREATE TABLE Products (product_id INT PRIMARY KEY, firm_id INT, company VARCHAR(100), market_value VARCHAR(100))";
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                Console.WriteLine("Created Products Table");

                // Create Table Query (Investment Manangers)
                sql = "CREATE TABLE Managers (manager_id INT PRIMARY KEY, firm_id INT, client_id INT, email VARCHAR(100), phone VARCHAR(100))";
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                Console.WriteLine("Created Managers Table");

                // Create Table Query (Investment Agents)
                sql = "CREATE TABLE Agents (agent_id INT PRIMARY KEY, manager_id INT, client_id INT, email VARCHAR(100), phone VARCHAR(100))";
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                Console.WriteLine("Created Agents Table");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }

        static void Main(string[] args)
        {
            SqlConnection conn = ConnectToDatabase();
            SqlCommand command = null;

            //string sql = "SELECT 1 FROM dbo";
            //command = new SqlCommand(sql, conn);
            //Console.WriteLine("Result: " + command.ExecuteReader().Read());

            //if (command == null) {
            //    sql = "";
            //    InitializeDatabase(conn, command, sql);
            //}

            Console.WriteLine("Here were are...");
            // Insert Query
            //sql = "INSERT INTO Profiles.Clients (client_id, name, email, phone, funds) VALUES (0, 'admin', 'admin@ca.com', null, null))";
            //command = new SqlCommand(sql, conn);
            //command.ExecuteNonQuery();


            conn.Close();
            Console.WriteLine("End of Program");
        }
    }
}

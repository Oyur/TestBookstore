using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBookstore
{
    class CustomerData
    {
      

        public static List<String> GetCustomerName(string customerid)
        {
            List<String> entries = new List<string>();
            using (SqliteConnection db =
               new SqliteConnection($"Filename=sqliteSample.db"))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT Customer_name from Customertable WHERE Customer_id ='" + customerid + "'" ,db) ;
                SqliteDataReader query = selectCommand.ExecuteReader();
                while (query.Read())
                {
                    entries.Add(query.GetString(0));
                }
                db.Close();
            }
            return entries;
            //methodใช้สำหรับรับค่าของ Customer_name ในตารางของ Customertable จากCustomer_id
        }
        public async static void InitializeDatabase()
        {
            using (SqliteConnection db =
               new SqliteConnection($"Filename=sqliteSample.db"))
            {
                db.Open();
                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS Customertable (Customer_id INTEGER PRIMARY KEY, " +
                    "Customer_name NVARCHAR(2048) NULL, Address NVARCHAR(2048) NULL, Email NVARCHAR(2048) NULL)";
                SqliteCommand createTable = new SqliteCommand(tableCommand, db);
                createTable.ExecuteReader();
            }
            //methodสำหรับสร้างตาราง Customertable (4ฟิล Customer_id,Customer_name,Address,Email)
        }
        public static List<String> GetCustomerAddress(string customerid)
        {
            List<String> entries = new List<string>();
            using (SqliteConnection db =
               new SqliteConnection($"Filename=sqliteSample.db"))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT Address from Customertable WHERE Customer_id ='" + customerid + "'", db);
                SqliteDataReader query = selectCommand.ExecuteReader();
                while (query.Read())
                {
                    entries.Add(query.GetString(0));
                }
                db.Close();
            }
            return entries;
            ////methodใช้สำหรับรับค่าของ Address ในตารางของ Customertable จากCustomer_id
        }
        public static List<String> GetCustomerEmail(string customerid)
        {
            List<String> entries = new List<string>();
            using (SqliteConnection db =
               new SqliteConnection($"Filename=sqliteSample.db"))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT Email from Customertable WHERE Customer_id ='" + customerid + "'", db);
                SqliteDataReader query = selectCommand.ExecuteReader();
                while (query.Read())
                {
                    entries.Add(query.GetString(0));
                }
                db.Close();
            }
            return entries;
            //methodใช้สำหรับรับค่าของ Email ในตารางของ Customertable จากCustomer_id
        }
        public static void AddData(string customer_id, string customer_name, string customer_address, string customer_email)
        {
            using (SqliteConnection db =
              new SqliteConnection($"Filename=sqliteSample.db"))
            {
                db.Open();
                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;
                // Use parameterized query to prevent SQL injection attacks
                insertCommand.CommandText = "INSERT INTO Customertable VALUES (@Customer_id, @Customer_name, @Customer_address, @Customer_email);";
                insertCommand.Parameters.AddWithValue("@Customer_id", customer_id);
                insertCommand.Parameters.AddWithValue("@Customer_name", customer_name);
                insertCommand.Parameters.AddWithValue("@Customer_address", customer_address);
                insertCommand.Parameters.AddWithValue("@Customer_email", customer_email);
                insertCommand.ExecuteReader();
                db.Close();
            }
            //method สำหรับเพิ่มข้อมูลลงในตาราง Customertable
        }
        public static void UpdateData(string customer_id, string customer_name, string customer_address, string customer_email)
        {
            using (SqliteConnection db =
              new SqliteConnection($"Filename=sqliteSample.db"))
            {
                db.Open();
                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;
                // Use parameterized query to prevent SQL injection attacks
                insertCommand.CommandText = "UPDATE Customertable SET Customer_id = @Customer_id, Customer_name = @Customer_name, Address = @Customer_address, Email = @Customer_email WHERE Customer_id = '" + customer_id + "';";
                insertCommand.Parameters.AddWithValue("@Customer_id", customer_id);
                insertCommand.Parameters.AddWithValue("@Customer_name", customer_name);
                insertCommand.Parameters.AddWithValue("@Customer_address", customer_address);
                insertCommand.Parameters.AddWithValue("@Customer_email", customer_email);
                insertCommand.ExecuteReader();
                db.Close();
            }
            //methodสำหรับอัพเดทข้อมูลตารางCustomertable
        }
        public static void DeleteCustomerData(string customerid)
        {
            using (SqliteConnection db =
               new SqliteConnection($"Filename=sqliteSample.db"))
            {
                db.Open();
                String removecommand = "DELETE FROM Customertable WHERE Customer_id = '" + customerid + "';";
                SqliteCommand removedata = new SqliteCommand(removecommand, db);
                removedata.ExecuteReader();
            }
            //methodใช้สำหรับลบข้อมูลในCustomertable จากCustomer_id
        }
        public static List<String> GetData(string customerid)
        {
            List<String> entries = new List<string>();
            using (SqliteConnection db =
               new SqliteConnection($"Filename=sqliteSample.db"))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT * from Customertable WHERE Customer_id = '" + customerid + "';", db);
                SqliteDataReader query = selectCommand.ExecuteReader();
                while (query.Read())
                {
                    entries.Add("ID : " + query.GetString(0));
                    entries.Add("Name : " + query.GetString(1));
                    entries.Add("Address : " + query.GetString(2));
                    entries.Add("E-mail : " + query.GetString(3));
                }
                db.Close();
            }
            return entries;
            //methodใช้สำหรับรับค่าข้อมูลทั้งหมดในตารางของ Customertable จากCustomer_id
        }

    }

}

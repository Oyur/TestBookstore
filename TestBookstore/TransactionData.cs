using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBookstore
{
    class TransactionData
    {
        public async static void InitializeDatabase()
        {
            using (SqliteConnection db =
               new SqliteConnection($"Filename=sqliteSample.db"))
            {
                db.Open();
                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS Transactiontable (List INTEGER PRIMARY KEY, " +
                    "ISBN INTEGER NULL, Customer_id NVARCHAR(2048) NULL, Quantity INTEGER NULL, TotalPrice INTEGER NULL)";
                SqliteCommand createTable = new SqliteCommand(tableCommand, db);
                createTable.ExecuteReader();
            }
            //method สร้างตารางTransaction ประกอบด้วยฟีล(List,ISBN,CUstomer_id,Quantity,TotalPrice)
        }
        public static List<String> GetData(string list)
        {
            List<String> entries = new List<string>();
            using (SqliteConnection db =
               new SqliteConnection($"Filename=sqliteSample.db"))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT * from Transactiontable WHERE List = '" + list + "';", db);
                SqliteDataReader query = selectCommand.ExecuteReader();
                while (query.Read())
                {
                    entries.Add(query.GetString(0));
                    entries.Add(query.GetString(1));
                    entries.Add(query.GetString(2));
                    entries.Add(query.GetString(3));
                    entries.Add(query.GetString(4));
                }
                db.Close();
            }
            return entries;
            //method ค้นหาข้อมูลทั้งหมดของ Transaction
        }
        public static void AddData(string isbn, string customer_id, int quantity, int totalprice)
        {
            using (SqliteConnection db =
              new SqliteConnection($"Filename=sqliteSample.db"))
            {
                db.Open();
                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;
                // Use parameterized query to prevent SQL injection attacks
                insertCommand.CommandText = "INSERT INTO Transactiontable VALUES (NULL, @ISBN, @Customer_id, @Quantity, @TotalPrice);";
                insertCommand.Parameters.AddWithValue("@ISBN", isbn);
                insertCommand.Parameters.AddWithValue("@Customer_id", customer_id);
                insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                insertCommand.Parameters.AddWithValue("@TotalPrice", totalprice);
                insertCommand.ExecuteReader();
                db.Close();
                //method เพิ่มข้อมูลการซื้อขายลงในตาราง Transaction
            }
        }
        public static List<String> Getlastlist()
        {
            List<String> entries = new List<string>();
            using (SqliteConnection db =
               new SqliteConnection($"Filename=sqliteSample.db"))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT MAX(LIST) AS LIST  FROM Transactiontable", db);
                SqliteDataReader query = selectCommand.ExecuteReader();
                while (query.Read())
                {
                    entries.Add(query.GetString(0));
                }
                db.Close();
            }
            return entries;
            //methodแสดงค่าล่าสุดของListหรือคำสั่งซื้อ
        }
     }
}

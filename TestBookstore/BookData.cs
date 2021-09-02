using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBookstore
{
    class BookData
    {
        public async static void InitializeDatabase()
        {
            using (SqliteConnection db =
               new SqliteConnection($"Filename=sqliteSample.db"))
            {
                db.Open();
                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS Booktable (ISBN INTEGER PRIMARY KEY, " +
                    "Title NVARCHAR(2048) NULL, Description NVARCHAR(2048) NULL, Price INTEGER NULL)";
                SqliteCommand createTable = new SqliteCommand(tableCommand, db);
                createTable.ExecuteReader();
            }
            //methodสำหรับสร้างตารางBooktable
        }
        public static void AddData(string title, string description, string price)
        {
            using (SqliteConnection db =
              new SqliteConnection($"Filename=sqliteSample.db"))
            {
                db.Open();
                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;
                // Use parameterized query to prevent SQL injection attacks
                insertCommand.CommandText = "INSERT INTO Booktable VALUES (NULL, @Title, @Description, @Price);";
                insertCommand.Parameters.AddWithValue("@Title", title);
                insertCommand.Parameters.AddWithValue("@Description", description);
                insertCommand.Parameters.AddWithValue("@Price", price);
                insertCommand.ExecuteReader();
                db.Close();
            }
            //methodสำหรับเพิ่มข้อมูลในตาราง Booktable
        }
        public static void DeleteBookData(string isbn)
        {
            using (SqliteConnection db =
               new SqliteConnection($"Filename=sqliteSample.db"))
            {
                db.Open();
                String removecommand = "DELETE FROM Booktable WHERE ISBN = '" + isbn + "';";
                SqliteCommand removedata = new SqliteCommand(removecommand, db);
                removedata.ExecuteReader();
            }
            //methodสำหรับลบข้อมูลใน Booktable
        }
        public static void UpdateData(string isbn, string title, string description, int price)
        {
            using (SqliteConnection db =
              new SqliteConnection($"Filename=sqliteSample.db"))
            {
                db.Open();
                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;
                // Use parameterized query to prevent SQL injection attacks
                insertCommand.CommandText = "UPDATE Booktable SET ISBN = @ISBN, Title = @Title, Description = @Description, Price = @Price WHERE ISBN = '" + isbn + "';";
                insertCommand.Parameters.AddWithValue("@ISBN", isbn);
                insertCommand.Parameters.AddWithValue("@Title", title);
                insertCommand.Parameters.AddWithValue("@Description", description);
                insertCommand.Parameters.AddWithValue("@Price", price);
                insertCommand.ExecuteReader();
                db.Close();
            }
            //methodสำหรับอัพเดทข้อมูลใน Booktable
        }
        public static List<String> GetData(string isbn)
        {
            List<String> entries = new List<string>();
            using (SqliteConnection db =
               new SqliteConnection($"Filename=sqliteSample.db"))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT * from Booktable WHERE ISBN = '" + isbn + "';", db);
                SqliteDataReader query = selectCommand.ExecuteReader();
                while (query.Read())
                {
                    entries.Add("ISBN : " + query.GetString(0));
                    entries.Add("Title : " + query.GetString(1));
                    entries.Add("Description : " + query.GetString(2));
                    entries.Add("Price : " + query.GetString(3));
                }
                db.Close();
            }
            return entries;
            //methodรับข้อมูลทั้งหมดจาก ISBN ใน Booktable
        }
        public static List<String> GetTitle(string title)
        {
            List<String> entries = new List<string>();
            using (SqliteConnection db =
               new SqliteConnection($"Filename=sqliteSample.db"))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT Title from Booktable WHERE ISBN ='" + title + "'", db);
                SqliteDataReader query = selectCommand.ExecuteReader();
                while (query.Read())
                {
                    entries.Add(query.GetString(0));
                }
                db.Close();
            }
            return entries;
            //methodรับข้อมูลทั้งหมด Title จาก ISBN ใน Booktable
        }
        public static List<String> GetDescription(string description)
        {
            List<String> entries = new List<string>();
            using (SqliteConnection db =
               new SqliteConnection($"Filename=sqliteSample.db"))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT Description from Booktable WHERE ISBN ='" + description + "'", db);
                SqliteDataReader query = selectCommand.ExecuteReader();
                while (query.Read())
                {
                    entries.Add(query.GetString(0));
                }
                db.Close();
            }
            return entries;
            //methodรับข้อมูลทั้งหมด Description จาก ISBN ใน Booktable
        }
        public static List<String> GetPrice(int price)
        {
            List<String> entries = new List<string>();
            using (SqliteConnection db =
               new SqliteConnection($"Filename=sqliteSample.db"))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT Price from Booktable WHERE ISBN ='" + price + "'", db);
                SqliteDataReader query = selectCommand.ExecuteReader();
                while (query.Read())
                {
                    entries.Add(query.GetString(0));
                }
                db.Close();
            }
            return entries;
            //methodรับข้อมูลทั้งหมด Price จาก ISBN ใน Booktable
        }
    }
}

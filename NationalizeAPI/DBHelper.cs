using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows;
using System.Data;
using System.Windows.Controls;
using System.Globalization;

namespace NationalizeAPI
{
    public class DBHelper : Window
    {
        public static SQLiteConnection CreateConnection()
        {
            try
            {
                var sqlite_conn = new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; ");
                sqlite_conn.Open();

                return sqlite_conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connection: {ex.Message}\n{ex.StackTrace}");
                return null;
            }
        }

        public static void InsertData(SQLiteConnection conn, Nationalize nationalize)
        {
            try
            {
                string insertNationalizeSql = $"INSERT INTO nationalize (count, name) VALUES ({nationalize.count}, '{nationalize.name}');";
                var cmd = new SQLiteCommand(insertNationalizeSql, conn);
                cmd.ExecuteNonQuery();

                long nationalizeId = conn.LastInsertRowId;

                foreach (var country in nationalize.country)
                {
                    string insertCountrySql = $"INSERT INTO country_info (nationalize_id, country_id, probability) " +
                                              $"VALUES ({nationalizeId}, '{country.country_id}', {country.probability.ToString(CultureInfo.InvariantCulture)});";
                    cmd = new SQLiteCommand(insertCountrySql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                
            }
        }


        public static void CreateTable(SQLiteConnection conn)
        {
            try
            {
                SQLiteCommand sqlite_cmd;

                string Createsql = $"CREATE TABLE IF NOT EXISTS nationalize (\r\n " +
                    $"id INTEGER PRIMARY KEY,\r\n " +
                    $"count INTEGER,\r\n " +
                    $"name TEXT UNIQUE\r\n);"; 

                string Createsql1 = $"CREATE TABLE IF NOT EXISTS country_info (\r\n" +
                    $"id INTEGER PRIMARY KEY,\r\n nationalize_id INTEGER,\r\n " +
                    $"country_id TEXT,\r\n " +
                    $"probability REAL,\r\n " +
                    $"FOREIGN KEY (nationalize_id)\r\n " +
                    $"REFERENCES nationalize (id)\r\n);";

                sqlite_cmd = conn.CreateCommand();

                sqlite_cmd.CommandText = Createsql;
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = Createsql1;
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public static void DropTable(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            string Createsql = $"DROP TABLE nationalize";

            string Createsql1 = $"DROP TABLE country_info";

            sqlite_cmd = conn.CreateCommand();

            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd.CommandText = Createsql1;
            sqlite_cmd.ExecuteNonQuery();
        }

    }
}

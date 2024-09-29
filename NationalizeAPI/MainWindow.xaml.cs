using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NationalizeAPI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SQLiteConnection conn = DBHelper.CreateConnection();

        public MainWindow()
        {
            InitializeComponent();
            DBHelper.CreateTable(conn);
            ReadData(conn);
        }

        private async void execute_button_Click(object sender, RoutedEventArgs e)
        {
            Nationalize nationalize = await APIHelper.GetNationalizeDataAsync(name_textBox.Text);
            nationalize_label.Content = nationalize;
            DBHelper.InsertData(conn,nationalize);
            ReadData(conn);
        }


        public void ReadData(SQLiteConnection conn)
        {
            string checkTableSql = "SELECT name FROM sqlite_master WHERE type='table' AND name='nationalize';";
            using (var checkCmd = new SQLiteCommand(checkTableSql, conn))
            {
                var result = checkCmd.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("Table nationalize doestn exist.");
                    return;
                }
            }

            string sql = $"SELECT * FROM nationalize ORDER BY id";
            using (var cmd = new SQLiteCommand(sql, conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        nationalize_dataGrid.ItemsSource = dt.DefaultView;
                    }
                    else
                    {
                        MessageBox.Show("No data.");
                    }
                }
            }

            sql = $"SELECT * FROM country_info ORDER BY id";
            using (var cmd = new SQLiteCommand(sql, conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        country_dataGrid.ItemsSource = dt.DefaultView;
                    }
                    else
                    {
                        MessageBox.Show("No data.");
                    }
                }
            }
            //conn.Close();
        }
    } 
}


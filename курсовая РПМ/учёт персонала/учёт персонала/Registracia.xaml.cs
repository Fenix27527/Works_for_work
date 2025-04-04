using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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
using System.Windows.Shapes;
using System.Data.Entity.Spatial;

namespace учёт_персонала
{
    /// <summary>
    /// Логика взаимодействия для Registracia.xaml
    /// </summary>
    public partial class Registracia : Window
    {
        string connectionString;
        SqlDataAdapter adapter;
        DataTable connectionTable;
        public Registracia()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CONNECTION"].ConnectionString;
        }

        
        public DataTable Select(string zapros)
        {
            connectionTable = new DataTable();
            SqlConnection connection = null;
            connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(zapros, connection);
            adapter = new SqlDataAdapter(command);
            connection.Open();
            adapter.Fill(connectionTable);
            return connectionTable;
        }

        private void But_Otmena_Click(object sender, RoutedEventArgs e)
        {
            MainWindow winMain = new MainWindow();
            this.Visibility = Visibility.Collapsed;
            winMain.ShowDialog();
        }

        private void But_Reg_Click(object sender, RoutedEventArgs e)
        {
            DataTable dts = Select("SELECT * FROM [dbo].[Logins1] WHERE [Login] = '" + tb_log.Text + "' OR [Email] = '" + tb_poch.Text + "' ");
            if (dts.Rows.Count > 0)
            {
                MessageBox.Show("Данные логин или почта уже зарегистрированы");
            }
            else
            {
                dts = Select("INSERT INTO Logins1 (Login,Parol,Email) VALUES ('" + tb_log.Text + "', '" + tb_reg.Text + "','" + tb_poch.Text + "')");
                MainWindow winMain = new MainWindow();
                this.Visibility = Visibility.Collapsed;
                winMain.ShowDialog();
            }
        }
    }
}

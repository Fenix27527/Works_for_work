using System;
using System.Collections.Generic;
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
using System.Configuration;
using System.Windows.Markup;
using System.Data.SqlClient;
using System.Data;

namespace учёт_персонала
{
    public partial class MainWindow : Window
    {
        string connectionString;
        SqlDataAdapter adapter;
        DataTable connectionTable;
        public MainWindow()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CONNECTION"].ConnectionString;
        }


        private void But_Close_Prog_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void But_vxod_Click(object sender, RoutedEventArgs e)
        {      
            DataTable dts = Select("SELECT * FROM [dbo].[Logins1] WHERE [Login] = '" + tb_Avtor.Text + "' AND [Parol] = '" + pb_Avtor.Password + "'");
            if (dts.Rows.Count > 0)
            {
                WindowMenu winMenu = new WindowMenu();
                this.Visibility = Visibility.Collapsed;
                winMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void But_reg_Click(object sender, RoutedEventArgs e)
        {
            Registracia winRegist = new Registracia();
            this.Visibility = Visibility.Collapsed;
            winRegist.ShowDialog();

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
    }   
}

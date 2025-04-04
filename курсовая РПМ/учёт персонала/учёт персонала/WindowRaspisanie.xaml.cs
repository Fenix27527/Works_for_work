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
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace учёт_персонала
{
    /// <summary>
    /// Логика взаимодействия для WindowRaspisanie.xaml
    /// </summary>
    public partial class WindowRaspisanie : Window
    {
        string connectionString;
        SqlDataAdapter adapter;
        DataTable Rasp_tb;
        public WindowRaspisanie()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CONNECTION"].ConnectionString;
        }

        private void Nazad3_Click(object sender, RoutedEventArgs e)
        {
            WindowMenu winMenu = new WindowMenu();
            this.Visibility = Visibility.Collapsed;
            winMenu.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string sql = "SELECT * FROM Raspisanie1";
            Rasp_tb = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);

                // установка команды на добавление для вызова хранимой процедуры
                adapter.InsertCommand = new SqlCommand("INSERTRas1", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Number", SqlDbType.Int, 0, "Number"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Podrazdelenie", SqlDbType.NVarChar, 100, "Podrazdelenie"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Dolznost", SqlDbType.NVarChar, 50, "Dolznost"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Kol_vo", SqlDbType.Int, 0, "Kol_vo"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Tarif", SqlDbType.Float, 0, "Tarif"));
                SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
                parameter.Direction = ParameterDirection.Output;

                connection.Open();
                adapter.Fill(Rasp_tb);
                TABLERaspisanie.ItemsSource = Rasp_tb.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        private void UpdateDB()
        {
            SqlCommandBuilder comandbuilder = new SqlCommandBuilder(adapter);
            adapter.Update(Rasp_tb);
        }

        private void updateButton_Rasp_Click(object sender, RoutedEventArgs e)
        {
            UpdateDB();
        }

        private void deleteButton_Rasp_Click(object sender, RoutedEventArgs e)
        {
            
            if (TABLERaspisanie.SelectedItems != null)
            {
                for (int i = 0; i < TABLERaspisanie.SelectedItems.Count; i++)
                {
                    DataRowView datarowView = TABLERaspisanie.SelectedItems[i] as DataRowView;
                    if (datarowView != null)
                    {
                        DataRow dataRow = (DataRow)datarowView.Row;
                        dataRow.Delete();
                    }
                }
            }
            UpdateDB();
        }

        private void Poisk_Click(object sender, RoutedEventArgs e)
        {
            Rasp_tb.DefaultView.RowFilter = string.Format("Podrazdelenie LIKE '%{0}%' OR Dolznost LIKE '%{0}%'", tb_Poisk.Text);
            //Rasp_tb.DefaultView.RowFilter = string.Format("CAST(Kol_vo AS nvarchar) LIKE '%{0}%'", tb_Poisk.Text);
            //OR Kol_vo LIKE '%{0}%' OR Tarif LIKE '%{0}%'
        }
    }
}

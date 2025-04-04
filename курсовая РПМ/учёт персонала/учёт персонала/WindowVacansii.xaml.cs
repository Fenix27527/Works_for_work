using System;
using System.Collections.Generic;
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
using System.Configuration;

namespace учёт_персонала
{
    /// <summary>
    /// Логика взаимодействия для WindowVacansii.xaml
    /// </summary>
    public partial class WindowVacansii : Window
    {
        string connectionString;
        SqlDataAdapter adapter;
        SqlDataAdapter adapter1;
        DataTable Vac_tb;
        DataTable Rez_tb;
        public WindowVacansii()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CONNECTION"].ConnectionString;
        }

        private void Nazad2_Click(object sender, RoutedEventArgs e)
        {
            WindowMenu winMenu = new WindowMenu();
            this.Visibility = Visibility.Collapsed;
            winMenu.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string sql = "SELECT * FROM Vacansii1";
            string sql2 = "SELECT * FROM Rezume1";
            Vac_tb = new DataTable();
            Rez_tb = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);

                // установка команды на добавление для вызова хранимой процедуры Vac
                adapter.InsertCommand = new SqlCommand("INSERTVac1", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Number", SqlDbType.Int, 0, "Number"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Dolznost", SqlDbType.NVarChar, 50, "Dolznost"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Uslovia", SqlDbType.NVarChar, 500, "Uslovia"));
                SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
                parameter.Direction = ParameterDirection.Output;

                connection.Open();
                adapter.Fill(Vac_tb);
                TABLEVacansii.ItemsSource = Vac_tb.DefaultView;
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


            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql2, connection);
                adapter1 = new SqlDataAdapter(command);

                //установка команды на добавление для вызова хранимой процедуры Rez
                adapter1.InsertCommand = new SqlCommand("INSERTRez1", connection);
                adapter1.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter1.InsertCommand.Parameters.Add(new SqlParameter("@Number", SqlDbType.Int, 0, "Number"));
                adapter1.InsertCommand.Parameters.Add(new SqlParameter("@FIO", SqlDbType.NVarChar, 50, "FIO"));
                adapter1.InsertCommand.Parameters.Add(new SqlParameter("@Dolznost", SqlDbType.NVarChar, 50, "Dolznost"));
                adapter1.InsertCommand.Parameters.Add(new SqlParameter("@Num_Vac", SqlDbType.Int, 0, "Num_Vac"));
                adapter1.InsertCommand.Parameters.Add(new SqlParameter("@Ssilka", SqlDbType.NVarChar, 100, "Ssilka"));
                SqlParameter parameter2 = adapter1.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
                parameter2.Direction = ParameterDirection.Output;

                connection.Open();
                adapter1.Fill(Rez_tb);
                TABLERezume.ItemsSource = Rez_tb.DefaultView;
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
            adapter.Update(Vac_tb);
        }
        private void UpdateDB2()
        {
            SqlCommandBuilder comandbuilder = new SqlCommandBuilder(adapter1);
            adapter1.Update(Rez_tb);
        }
        
        private void updateButton_Rez_Click(object sender, RoutedEventArgs e)
        {
            UpdateDB2();
        }

        private void deleteButton_Rez_Click(object sender, RoutedEventArgs e)
        {

            if (TABLERezume.SelectedItems != null)
            {
                for (int i = 0; i < TABLERezume.SelectedItems.Count; i++)
                {
                    DataRowView datarowView = TABLERezume.SelectedItems[i] as DataRowView;
                    if (datarowView != null)
                    {
                        DataRow dataRow = (DataRow)datarowView.Row;
                        dataRow.Delete();
                    }
                }
            }
            UpdateDB2();
        }

        private void updateButton_Vac_Click(object sender, RoutedEventArgs e)
        {
            UpdateDB();
        }

        private void deleteButton_Vac_Click(object sender, RoutedEventArgs e)
        {
            if (TABLEVacansii.SelectedItems != null)
            {
                for (int i = 0; i < TABLEVacansii.SelectedItems.Count; i++)
                {
                    DataRowView datarowView = TABLEVacansii.SelectedItems[i] as DataRowView;
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
            Vac_tb.DefaultView.RowFilter = string.Format("Dolznost LIKE '%{0}%' OR Uslovia LIKE '%{0}%' ", tb_Poisk.Text);
            Rez_tb.DefaultView.RowFilter = string.Format("FIO LIKE '%{0}%' OR Dolznost LIKE '%{0}%' OR Ssilka LIKE '%{0}%' ", tb_Poisk.Text);
        }

        
    }    
}

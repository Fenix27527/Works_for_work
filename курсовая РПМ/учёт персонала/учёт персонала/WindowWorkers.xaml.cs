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
using System.Windows.Markup;
using MaterialDesignColors;
using System.Windows.Controls.Primitives;

namespace учёт_персонала
{
    public partial class WindowWorkers : Window 
    {
        string connectionString;
        SqlDataAdapter adapter;
        DataTable Personal_dt;
        public WindowWorkers()
        {
            InitializeComponent();
            // получаем строку подключения из app.config
            connectionString = ConfigurationManager.ConnectionStrings["CONNECTION"].ConnectionString;
            TABLEPersonal.RowEditEnding += TABLEPersonal_RowEditEnding;
        }
        
        
        private void But_Nazad1_Click(object sender, RoutedEventArgs e)
        {
            WindowMenu winMenu = new WindowMenu();
            this.Visibility = Visibility.Collapsed;
            winMenu.ShowDialog();
        }

        
        private void UpdateDB()
        {
            SqlCommandBuilder comandbuilder = new SqlCommandBuilder(adapter);
            adapter.Update(Personal_dt);
        }
        private void updateButton_Per_Click(object sender, RoutedEventArgs e)
        {
            UpdateDB();
        }
        private void TABLEPersonal_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            UpdateDB();
        }
        private void deleteButton_Per_Click(object sender, RoutedEventArgs e)
        {
            if (TABLEPersonal.SelectedItems != null)
            {
                for (int i = 0; i < TABLEPersonal.SelectedItems.Count; i++)
                {
                    DataRowView datarowView = TABLEPersonal.SelectedItems[i] as DataRowView;
                    if (datarowView != null)
                    {
                        DataRow dataRow = (DataRow)datarowView.Row;
                        dataRow.Delete();
                    }
                }
            }
            UpdateDB();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string sql = "SELECT * FROM Personal";
            Personal_dt = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);

                // установка команды на добавление для вызова хранимой процедуры
                
                adapter.InsertCommand = new SqlCommand("INSERTPersonal2", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Number", SqlDbType.Int, 0, "Number"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@FIO", SqlDbType.NVarChar, 50, "FIO"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Podrazdelenie", SqlDbType.NVarChar, 50, "Podrazdelenie"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Dolznost", SqlDbType.NVarChar, 50, "Dolznost"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@INN", SqlDbType.NVarChar, 50, "INN"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Adres", SqlDbType.NVarChar, 50, "Adres"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Data_priema", SqlDbType.NVarChar, 50, "Data_priema"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Semia", SqlDbType.NVarChar, 250, "Semia"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Obrazovanie", SqlDbType.NVarChar, 250, "Obrazovanie"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Nagradi", SqlDbType.NVarChar, 500, "Nagradi"));
                SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@id", SqlDbType.Int, 0, "Id");
                parameter.Direction = ParameterDirection.Output;

                connection.Open();
                adapter.Fill(Personal_dt);
                TABLEPersonal.ItemsSource = Personal_dt.DefaultView;
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

        private void Poisk_Click(object sender, RoutedEventArgs e)
        {
            Personal_dt.DefaultView.RowFilter = string.Format("FIO LIKE '%{0}%' OR Podrazdelenie LIKE '%{0}%' OR Dolznost LIKE '%{0}%' OR Adres LIKE '%{0}%' " +
                "OR Data_priema LIKE '%{0}%' OR Semia LIKE '%{0}%' OR Nagradi LIKE '%{0}%' OR INN LIKE '%{0}%'", tb_Poisk.Text);
        }
    }
}

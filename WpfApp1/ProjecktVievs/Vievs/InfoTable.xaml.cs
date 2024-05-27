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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1.ProjecktVievs.Vievs
{
    /// <summary>
    /// Логика взаимодействия для InfoTable.xaml
    /// </summary>
    public partial class InfoTable : Page
    {
        private DataSet dataSet = new DataSet();
        private string connectionString = "Data Source=(localdb)\\MSSqlLocalDb;Initial Catalog=RestoranDB;Integrated Security=True";
        public InfoTable()
        {
            InitializeComponent();
            FetchData("Бронирование", DataGrid1);
            FetchData("Детали_Заказа", DataGrid2);
            FetchData("Заказы", DataGrid3);
            FetchData("Залы", DataGrid4);
            FetchData("Меню", DataGrid5);
            FetchData("Столы", DataGrid6);
            FetchData("Счета", DataGrid7);
        }

        private void FetchData(string tableName, DataGrid dataGrid)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM {tableName}", connection);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                connection.Open();
                adapter.Fill(dt);
                connection.Close();
            }
            dt.TableName = tableName;
            dataSet.Tables.Add(dt);
            dataGrid.ItemsSource = dt.DefaultView;
        }

        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    foreach (DataTable dt in dataSet.Tables)
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM {dt.TableName}", connection);
                        SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                        adapter.UpdateCommand = cmdBuilder.GetUpdateCommand();
                        adapter.Update(dt);
                    }
                    MessageBox.Show("Изменения сохранены успешно!");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void DeleteSelectedRows_Click(object sender, RoutedEventArgs e)
        {
            // Перебор всех DataGrid и удаление выбранных строк
            foreach (DataGrid dg in new DataGrid[] { DataGrid1, DataGrid2, DataGrid3, DataGrid4, DataGrid5, DataGrid6, DataGrid7 })
            {
                DeleteSelectedRowsFromDataGrid(dg);
            }
        }

        private void DeleteSelectedRowsFromDataGrid(DataGrid dataGrid)
        {
            if (dataGrid.SelectedItems.Count > 0)
            {
                var rowsToDelete = dataGrid.SelectedItems.Cast<DataRowView>().ToList();
                foreach (var rowView in rowsToDelete)
                {
                    rowView.Row.Delete();
                }
            }
        }

        private void UpdateDatabase()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (DataTable dt in dataSet.Tables)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM {dt.TableName}", connection);
                    SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                    adapter.DeleteCommand = cmdBuilder.GetDeleteCommand();
                    adapter.Update(dt);
                }
                MessageBox.Show("Выбранные строки удалены успешно!");
                connection.Close();
            }
        }



        private void DataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
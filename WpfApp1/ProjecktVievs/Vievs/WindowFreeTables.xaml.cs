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
    /// Логика взаимодействия для WindowFreeTables.xaml
    /// </summary>
    public partial class WindowFreeTables : Page
    {
        public WindowFreeTables()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSqlLocalDb;Initial Catalog=RestoranDB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open(); // Не забудьте открыть соединение
                string query = "SELECT * FROM ПроверитьСвободныеСтолики(@Category);";
                SqlCommand command = new SqlCommand(query, connection);

                // Получаем выбранную дату из DatePicker и преобразуем её в строку
                DateTime selectedDate = datePickerCategory.SelectedDate ?? DateTime.Now;
                command.Parameters.AddWithValue("@Category", selectedDate.ToString("yyyy-MM-dd"));

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DataGrid1.ItemsSource = dt.DefaultView;
            }
        }

        private void textBoxCategory_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

    


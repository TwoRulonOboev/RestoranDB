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
    /// Логика взаимодействия для WindowRevenue.xaml
    /// </summary>
    public partial class WindowRevenue : Page
    {
        public WindowRevenue()
        {
            InitializeComponent();
        }
        // Обновите этот метод для обработки изменения выбранной даты в DatePicker
        private void DatePickerCategory_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            // Ваш код для обработки новой выбранной даты
        }

        private void DataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Ваш код для обработки выбора в DataGrid
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSqlLocalDb;Initial Catalog=RestoranDB;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Открываем соединение

                    string query = "SELECT * FROM ПолучитьВыручкуРесторана(@Category);";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Проверяем, что datePickerCategory не null
                    DateTime selectedDate = datePickerCategory?.SelectedDate ?? DateTime.Now;
                    command.Parameters.AddWithValue("@Category", selectedDate.ToString("yyyy-MM-dd"));

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DataGrid1.ItemsSource = dt.DefaultView;
                }
            }
            catch (SqlException ex)
            {
                // Обработка исключения SQL
                MessageBox.Show($"Ошибка базы данных: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Обработка других исключений
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

    }
}

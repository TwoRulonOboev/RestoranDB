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
    /// Логика взаимодействия для WindowBooking.xaml
    /// </summary>
    public partial class WindowBooking : Page
    {
        public WindowBooking()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSqlLocalDb;Initial Catalog=RestoranDB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Убедитесь, что метод 'ПолучитьИнформациюОЗаказах' существует в вашей базе данных и возвращает таблицу
                string query = "SELECT * FROM ПолучитьИнформациюОБронированииСтолов();";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DataGrid1.ItemsSource = dt.DefaultView;
            }
        }

        private void DataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

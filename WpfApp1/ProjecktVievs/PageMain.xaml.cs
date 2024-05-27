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
using WpfApp1;
using WpfApp1.ProjecktVievs;
using WpfApp1.ProjecktVievs.Vievs;

namespace RestoranKuesa.ProjecktVievs
{
    /// <summary>
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        private MainWindow glavnoe;

        public PageMain(MainWindow glavnoe)
        {
            InitializeComponent();
            this.glavnoe = glavnoe; 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Поле 'Ключ доступа' не может быть пустым.", "Ошибка");
                return;
            }

            if (username != "321")
            {
                MessageBox.Show("Неверный ключ доступа", "Ошибка");
                return;
            }
            else
            {
                glavnoe.EnableButtons();
            }
        }

        private void UsernameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

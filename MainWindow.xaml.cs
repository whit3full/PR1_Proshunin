using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PR1_Proshunin
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Fon_Click(object sender, RoutedEventArgs e)
        {
            GraphCreate graphCreate = new GraphCreate();
            graphCreate.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;

            if (menuItem.Header.ToString() == "Синий")
            {
                this.Background = Brushes.LightBlue;
            }
           else if (menuItem.Header.ToString() == "Зеленый")
            {
                this.Background = Brushes.LightGreen;
            }
            else if (menuItem.Header.ToString() == "Аква")
            {
                this.Background = Brushes.Aqua;
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик не в чем не виноват\nОн к успеху шел\nНЕ ПОЛУЧИЛОСЬ\nНЕ ФОРТАНУЛО", "Information",
                MessageBoxButton.OK, MessageBoxImage.Information);
     
        }
    }
}

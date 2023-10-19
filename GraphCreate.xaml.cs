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

namespace PR1_Proshunin
{
    /// <summary>
    /// Логика взаимодействия для GraphCreate.xaml
    /// </summary>
    public partial class GraphCreate : Window
    {
        private double brushSize = 1.0;
        public GraphCreate()
        {
            InitializeComponent();
        }

        private void colorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch ((sender as ComboBox).SelectedIndex)
            {
                case 0:
                    Brush1.DefaultDrawingAttributes.Color = Colors.Black;
                    break;
                case 1:
                    Brush1.DefaultDrawingAttributes.Color = Colors.Red;
                    break;
                case 2:
                    Brush1.DefaultDrawingAttributes.Color = Colors.Blue;
                    break;
                case 3:
                    Brush1.DefaultDrawingAttributes.Color = Colors.Green;
                    break;

            }
        }

        private void www_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            brushSize = www.Value;
        }
    }
}

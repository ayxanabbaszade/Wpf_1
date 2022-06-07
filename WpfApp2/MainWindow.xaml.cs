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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StackPanel_LayoutUpdated(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                Random random = new Random();
                SolidColorBrush brush =
                   new SolidColorBrush(
                       Color.FromRgb(
                       (byte)random.Next(255),
                       (byte)random.Next(255),
                       (byte)random.Next(255)
                       ));
                btn.Background = brush;

                MessageBox.Show($"Name: {btn.Name}\nColor: {btn.Background}");
            }
        }

        private void Button_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button btn)
            {
                if (r1.Children.Contains(btn))
                    r1.Children.Remove(btn);
                else
                    r2.Children.Remove(btn);

                Title = (string)btn.Content;
            }
        }



    }
}

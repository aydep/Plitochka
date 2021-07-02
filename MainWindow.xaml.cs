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

namespace Plitochka
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

        private void button_left_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(plit1, Canvas.GetLeft(plit1)-40);
        }

        private void button_right_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(plit1, Canvas.GetLeft(plit1) + 40);

        }
    }
}

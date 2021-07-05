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

        string focused_plit;
        UIElement focused_plit_el;

        Random rnd = new Random();
        Brush customColor;

        private void button_left_Click(object sender, RoutedEventArgs e)
        {
            var column = Grid.GetColumn(focused_plit_el);
            
            if (column > 0) { Grid.SetColumn(focused_plit_el, column - 1); }
        }

        private void button_right_Click(object sender, RoutedEventArgs e)
        {
            var columnSpan = Grid.GetColumnSpan(focused_plit_el);
            var column = Grid.GetColumn(focused_plit_el);

            if (column < (10-columnSpan)) { Grid.SetColumn(focused_plit_el, column + 1); }
        }

        public void Plit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            focused_plit = ((Border)e.OriginalSource).Name;
            tehta.Text = focused_plit;
            focused_plit_el = (UIElement)LogicalTreeHelper.FindLogicalNode(setkaPlitki, focused_plit);
        }

        private void button_rotate_Click(object sender, RoutedEventArgs e)
        {
            var rowSpan = Grid.GetRowSpan(focused_plit_el);
            var columnSpan = Grid.GetColumnSpan(focused_plit_el);

            Grid.SetRowSpan(focused_plit_el, columnSpan);
            Grid.SetColumnSpan(focused_plit_el, rowSpan);
        }

        private void button_up_Click(object sender, RoutedEventArgs e)
        {
            var row = Grid.GetRow(focused_plit_el);
            
            if (row > 0) { Grid.SetRow(focused_plit_el, row - 1); }
        }

        private void button_down_Click(object sender, RoutedEventArgs e)
        {
            var row = Grid.GetRow(focused_plit_el);
            var rowSpan = Grid.GetRowSpan(focused_plit_el);

            if (row < (10-rowSpan)) { Grid.SetRow(focused_plit_el, row + 1); }
        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            customColor = new SolidColorBrush(Color.FromRgb((byte)rnd.Next(1, 255), (byte)rnd.Next(1, 255), (byte)rnd.Next(1, 255)));

            Border newBorder = new Border
            {
                Width = 80,
                Height = 40,
                Background = customColor,
                Name = "plit" + (setkaPlitki.Children.Count + 1)
            };

            MessageBox.Show(setkaPlitki.Children.Count.ToString());

            MessageBox.Show(newBorder.Name);

            setkaPlitki.Children.Add(newBorder);

            MessageBox.Show(setkaPlitki.Children.Count.ToString());
        }

        private void button_del_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

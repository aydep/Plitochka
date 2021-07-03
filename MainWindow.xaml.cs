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
            Canvas.SetLeft(focused_plit_el, Canvas.GetLeft(focused_plit_el) - 40);
        }

        private void button_right_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(focused_plit_el, Canvas.GetLeft(focused_plit_el) + 40);   
        }

        public void Plit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            focused_plit = ((Rectangle)e.OriginalSource).Name;
            tehta.Text = focused_plit;
            focused_plit_el = (UIElement)LogicalTreeHelper.FindLogicalNode(canv, focused_plit);
        }

        private void button_rotate_left_Click(object sender, RoutedEventArgs e)
        {
            canv.Children.Remove(focused_plit_el);
        }

        private void button_rotate_right_Click(object sender, RoutedEventArgs e)
        {
            customColor = new SolidColorBrush(Color.FromRgb((byte)rnd.Next(1,255), (byte)rnd.Next(1, 255), (byte)rnd.Next(1, 255)));

            Rectangle newRectangle = new Rectangle
            {
                Width = 80,
                Height = 40,
                Fill = customColor,
                Name = "plit" + (canv.Children.Count+1)
            };

            Canvas.SetLeft(newRectangle, rnd.Next(1, 400));
            Canvas.SetTop(newRectangle, rnd.Next(1, 400));

            canv.Children.Add(newRectangle);
        }
    }
}

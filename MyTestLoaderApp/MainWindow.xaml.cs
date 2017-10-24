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

namespace MyTestLoaderApp
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

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double value = ((Slider)sender).Value;
            string round_value = Math.Round(((Slider)sender).Value, 2).ToString();

            if (value == 0 || value == 100)
            {
                bar.Value = value;
                textBlock1.Text = round_value + ".00%";
                textBlock2.Text = round_value + ".00%";
            }
            else
            {
                bar.Value = value;
                textBlock1.Text = round_value + "%";
                textBlock2.Text = round_value + "%";
            }
        }
    }
}

using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
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

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            if (TextBlock0 != null && TextBlock0.Text != "0")
                TextBlock0.Text = TextBlock0.Text + "0";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (TextBlock0.Text == "0")
                TextBlock0.Text = "1";
            else
                TextBlock0.Text += "1";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (TextBlock0.Text == "0")
                TextBlock0.Text = "2";
            else
                TextBlock0.Text += "2";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (TextBlock0.Text == "0")
                TextBlock0.Text = "3";
            else
                TextBlock0.Text += "3";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (TextBlock0.Text == "0")
                TextBlock0.Text = "4";
            else
                TextBlock0.Text += "4";
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (TextBlock0.Text == "0")
                TextBlock0.Text = "5";
            else
                TextBlock0.Text += "5";
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (TextBlock0.Text == "0")
                TextBlock0.Text = "6";
            else
                TextBlock0.Text += "6";
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (TextBlock0.Text == "0")
                TextBlock0.Text = "7";
            else
                TextBlock0.Text += "7";
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (TextBlock0.Text == "0")
                TextBlock0.Text = "8";
            else
                TextBlock0.Text += "8";
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (TextBlock0.Text == "0")
                TextBlock0.Text = "9";
            else
                TextBlock0.Text += "9";
        }
    }
}
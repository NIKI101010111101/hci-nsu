using MathLibrary;
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
using static System.Net.Mime.MediaTypeNames;


namespace WpfApp1
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

        private void Num0_Click(object sender, RoutedEventArgs e) => output.Text += '0';
        private void Num1_Click(object sender, RoutedEventArgs e) => output.Text += '1';
        private void Num2_Click(object sender, RoutedEventArgs e) => output.Text += '2';
        private void Num3_Click(object sender, RoutedEventArgs e) => output.Text += '3';
        private void Num4_Click(object sender, RoutedEventArgs e) => output.Text += '4';
        private void Num5_Click(object sender, RoutedEventArgs e) => output.Text += '5';
        private void Num6_Click(object sender, RoutedEventArgs e) => output.Text += '6';
        private void Num7_Click(object sender, RoutedEventArgs e) => output.Text += '7';
        private void Num8_Click(object sender, RoutedEventArgs e) => output.Text += '8';
        private void Num9_Click(object sender, RoutedEventArgs e) => output.Text += '9';

        private void GetResult_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(output.Text))
            {
                double result = 0;
                if (output.Text.Contains('+'))
                {
                    string[] nums = output.Text.Split('+');
                    result = MathClass.plus(nums);
                }
                if (output.Text.Contains('-'))
                {
                    string[] nums = output.Text.Split('-');
                    result = MathClass.minus(nums);
                }
                if (output.Text.Contains('*'))
                {
                    string[] nums = output.Text.Split('*');
                    result = MathClass.multiplication(nums);
                }
                if (output.Text.Contains('/'))
                {
                    string[] nums = output.Text.Split('/');
                    result = MathClass.division(nums);
                }
                if (output.Text.Contains('%'))
                {
                    string[] nums = output.Text.Split('%');
                    result = MathClass.percent(nums);
                }
                if (output.Text.Contains('^'))
                {
                    string[] nums = output.Text.Split('^');
                    result = MathClass.pow(nums);
                }
                output.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            output.Text = "";
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            string text = output.Text;

            if (!string.IsNullOrEmpty(text))
            {
                output.Text = text[..^1];
            }
        }
        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            string text = output.Text;
            if (!string.IsNullOrEmpty(text))
            {
                if (!text.Contains('+') && !text.Contains('-') && !text.Contains('*') && !text.Contains('/')) output.Text += "+";
            }
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            string text = output.Text;
            if (!string.IsNullOrEmpty(text))
            {
                if (!text.Contains('+') && !text.Contains('-') && !text.Contains('*') && !text.Contains('/')) output.Text += "-";
            }
        }

        private void mnog_Click(object sender, RoutedEventArgs e)
        {
            string text = output.Text;
            if (!string.IsNullOrEmpty(text))
            {
                if (!text.Contains('+') && !text.Contains('-') && !text.Contains('*') && !text.Contains('/')) output.Text += "*";
            }
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            string text = output.Text;
            if (!string.IsNullOrEmpty(text))
            {
                if (!text.Contains('+') && !text.Contains('-') && !text.Contains('*') && !text.Contains('/')) output.Text += "/";
            }
        }
        private void percent_click(object sender, RoutedEventArgs e)
        {
            string text = output.Text;
            if (!string.IsNullOrEmpty(text))
            {
                if (!text.Contains('+') && !text.Contains('-') && !text.Contains('*') && !text.Contains('/')) output.Text += "%";
            }
        }

        private void pow_Click(object sender, RoutedEventArgs e)
        {
            string text = output.Text;
            if (!string.IsNullOrEmpty(text))
            {
                if (!text.Contains('+') && !text.Contains('-') && !text.Contains('*') && !text.Contains('/')) output.Text += "^";
            }
        }

        

        private void comma_Click(object sender, RoutedEventArgs e)
        {
            string text = output.Text;
            if (!string.IsNullOrEmpty(text))
            {
                if (text[^1] != '+' && text[^1] != '-' && text[^1] != '*' && text[^1] != '/' && text[^1] != ',') output.Text += ",";
            }
        }
        
    }
}
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

namespace Date
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

        private void ValidateButton_Click(object sender, RoutedEventArgs e)
        {
            if (TryParseInput(out int d, out int m, out int y))
            {
                var date = new ClassDate(d, m, y);
                OutputBox.Text = date.Print();
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (TryParseInput(out int d, out int m, out int y))
            {
                var date = new ClassDate(d, m, y);
                OutputBox.Text = date.Next().Print();
            }
        }

        private void PrevButton_Click(object sender, RoutedEventArgs e)
        {
            if (TryParseInput(out int d, out int m, out int y))
            {
                var date = new ClassDate(d, m, y);
                OutputBox.Text = date.Previous().Print();
            }
        }

        private void ForwardButton_Click(object sender, RoutedEventArgs e)
        {
            if (TryParseInput(out int d, out int m, out int y) && TryParseN(out int n))
            {
                var date = new ClassDate(d, m, y);
                OutputBox.Text = date.PrintForward(n);
            }
        }

        private void BackwardButton_Click(object sender, RoutedEventArgs e)
        {
            if (TryParseInput(out int d, out int m, out int y) && TryParseN(out int n))
            {
                var date = new ClassDate(d, m, y);
                OutputBox.Text = date.PrintBackward(n);
            }
        }

        private bool TryParseInput(out int day, out int month, out int year)
        {
            day = month = year = 0;
            if (!int.TryParse(DayBox.Text, out day)) return false;
            if (!int.TryParse(MonthBox.Text, out month)) return false;
            if (!int.TryParse(YearBox.Text, out year)) return false;
            return true;
        }

        private bool TryParseN(out int n)
        {
            n = 0;
            return int.TryParse(NBox.Text, out n) && n > 0;
        }
    }
}
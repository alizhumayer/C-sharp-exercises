using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace FeladatValaszto
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Initialize();
        }

        private void Initialize()
        {
            var solutions = typeof(HSGradSolutions.ErettsegiAttribute).Assembly.GetTypes().Where(t =>
            {
                return t.GetCustomAttributes(typeof(HSGradSolutions.ErettsegiAttribute), false).FirstOrDefault() as HSGradSolutions.ErettsegiAttribute != null;
            }).Select(t => new { type = t, attr = t.GetCustomAttributes(typeof(HSGradSolutions.ErettsegiAttribute), false).FirstOrDefault() as HSGradSolutions.ErettsegiAttribute }).ToArray();

            List<SelectorItem> solutionItems = new List<SelectorItem>(solutions.OrderBy(x => x.attr.Date).Select(x => new SelectorItem(x.attr.Date, x.attr.Title, x.attr.Difficulty)));
            cbxTestSelector.ItemsSource = solutionItems;
            cbxTestSelector.SelectedIndex = 0;
        }

        private void btTest_Click(object sender, RoutedEventArgs e)
        {
            var item = cbxTestSelector.SelectedItem as SelectorItem;
            System.Diagnostics.Process.Start($"data\\{item.Date.Year}{item.Date.Month:00}\\feladat.pdf");
        }

        private void btStart_Click(object sender, RoutedEventArgs e)
        {
            var item = cbxTestSelector.SelectedItem as SelectorItem;
            System.Diagnostics.Process.Start("ErettsegiMegoldas.exe", $"{item.Date.Year} {item.Date.Month}");
        }

        private class SelectorItem
        {
            public DateTime Date { get; }
            public string Title { get; }
            public int Difficulty { get; }
            public string DateString => GetDateString();
            public string DifficultyString => new string('*', Difficulty);

            public SelectorItem(DateTime date, string title, int difficulty)
            {
                Date = date;
                Title = title;
                Difficulty = difficulty;
            }

            public string GetDateString()
            {
                string month = "";
                switch (Date.Month)
                {
                    case 1: month = "január"; break;
                    case 2: month = "február"; break;
                    case 3: month = "március"; break;
                    case 4: month = "április"; break;
                    case 5: month = "május"; break;
                    case 6: month = "június"; break;
                    case 7: month = "július"; break;
                    case 8: month = "augusztus"; break;
                    case 9: month = "szeptember"; break;
                    case 10: month = "október"; break;
                    case 11: month = "november"; break;
                    case 12: month = "december"; break;
                }

                return $"{Date.Year}. {month}";
            }
        }

        
    }
    public class DifficultyToVisibilityConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                int target = int.TryParse(parameter?.ToString(), out int i) ? i : 0;
                if (value is int v)
                    return v >= target ? Visibility.Visible : Visibility.Collapsed;
                return Visibility.Collapsed;
            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                throw new NotImplementedException();
            }
        }
}

using System.Windows;

namespace WeatherApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenTranslatorWindow(object sender, RoutedEventArgs e)
        {
            TranslatorWindow translatorWindow = new TranslatorWindow();
            translatorWindow.Show();
        }

        private void OpenCalculatorWindow(object sender, RoutedEventArgs e)
        {
            CalculatorWindow calculatorWindow = new CalculatorWindow();
            calculatorWindow.Show();
        }

        private void OpenRangeCheckerWindow(object sender, RoutedEventArgs e)
        {
            RangeCheckerWindow rangeCheckerWindow = new RangeCheckerWindow();
            rangeCheckerWindow.Show();
        }

        private void OpenPasswordWindow(object sender, RoutedEventArgs e)
        {
            PasswordWindow passwordWindow = new PasswordWindow();
            passwordWindow.Show();
        }
    }
}

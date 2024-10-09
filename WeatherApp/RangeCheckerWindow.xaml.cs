using System;
using System.Windows;

namespace WeatherApp
{
    public partial class RangeCheckerWindow : Window
    {
        public RangeCheckerWindow()
        {
            InitializeComponent();
        }

        private void CheckRange(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(numberTextBox.Text, out int number) && number >= 0 && number <= 100)
            {
                if (number <= 14)
                    resultTextBlock.Text = "[0 - 14]";
                else if (number <= 35)
                    resultTextBlock.Text = "[15 - 35]";
                else if (number <= 50)
                    resultTextBlock.Text = "[36 - 50]";
                else
                    resultTextBlock.Text = "[51 - 100]";
            }
            else
            {
                resultTextBlock.Text = "Число вне диапазона или неверный ввод.";
            }
        }
    }
}
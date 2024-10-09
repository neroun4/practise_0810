using System.Windows;

namespace WeatherApp
{
    public partial class CalculatorWindow : Window
    {
        public CalculatorWindow()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            double operand1 = 10; // Пример значения
            double operand2 = 5;  // Пример значения
            string sign = operationTextBox.Text;

            switch (sign)
            {
                case "+":
                    resultTextBlock.Text = (operand1 + operand2).ToString();
                    break;
                case "-":
                    resultTextBlock.Text = (operand1 - operand2).ToString();
                    break;
                case "*":
                    resultTextBlock.Text = (operand1 * operand2).ToString();
                    break;
                case "/":
                    if (operand2 != 0)
                    {
                        resultTextBlock.Text = (operand1 / operand2).ToString();
                    }
                    else
                    {
                        resultTextBlock.Text = "Ошибка: деление на ноль.";
                    }
                    break;
                default:
                    resultTextBlock.Text = "Неизвестная операция.";
                    break;
            }
        }
    }
}
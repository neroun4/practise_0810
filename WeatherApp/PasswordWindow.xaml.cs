using System.Windows;

namespace WeatherApp
{
    public partial class PasswordWindow : Window
    {
        private const string correctPassword = "secret123"; // Правильный пароль

        public PasswordWindow()
        {
            InitializeComponent();
        }

        private void CheckPassword(object sender, RoutedEventArgs e)
        {
            string enteredPassword = passwordTextBox.Text;

            if (enteredPassword == correctPassword)
            {
                resultTextBlock.Text = "Доступ разрешен! Секретное сообщение: 'Погода сегодня хорошая!'";
            }
            else
            {
                resultTextBlock.Text = "Неверный пароль. Попробуйте снова.";
                passwordTextBox.Clear(); // Очистить поле ввода пароля
                passwordTextBox.Focus();  // Установить фокус на поле ввода
            }
        }
    }
}
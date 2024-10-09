using System.Collections.Generic;
using System.Windows;

namespace WeatherApp
{
    public partial class TranslatorWindow : Window
    {
        private Dictionary<string, string> translations = new Dictionary<string, string>
        {
            {"солнце", "sun"},
            {"дождь", "rain"},
            {"ветер", "wind"},
            {"снег", "snow"},
            {"облако", "cloud"},
            {"температура", "temperature"},
            {"погода", "weather"},
            {"мгла", "fog"},
            {"град", "hail"},
            {"буря", "storm"}
        };

        public TranslatorWindow()
        {
            InitializeComponent();
        }

        private void TranslateWord(object sender, RoutedEventArgs e)
        {
            string input = russianWordTextBox.Text.ToLower();
            if (translations.ContainsKey(input))
            {
                resultTextBlock.Text = translations[input];
            }
            else
            {
                resultTextBlock.Text = "Такого слова нет.";
            }
        }
    }
}
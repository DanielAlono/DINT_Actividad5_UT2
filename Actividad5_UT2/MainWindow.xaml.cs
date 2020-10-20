using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace Actividad5_UT2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            azulRadioButton.IsChecked = true;
        }

        private void negritaCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (negritaCheckBox.IsChecked == true) salidaTextBox.FontWeight = FontWeights.Bold;
            else salidaTextBox.FontWeight = FontWeights.Normal;
        }

        private void cursivaCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (cursivaCheckBox.IsChecked == true) salidaTextBox.FontStyle = FontStyles.Italic;
            else salidaTextBox.FontStyle = FontStyles.Normal;
        }

        private void azulRadioButton_Click(object sender, RoutedEventArgs e)
        {
            salidaTextBox.Foreground = new SolidColorBrush(Colors.Blue);
        }

        private void rojoRadioButton_Click(object sender, RoutedEventArgs e)
        {
            salidaTextBox.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void verdeRadioButton_Click(object sender, RoutedEventArgs e)
        {
            salidaTextBox.Foreground = new SolidColorBrush(Colors.Green);
        }

        private void entradaTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            salidaTextBox.Text = entradaTextBox.Text;
        }
    }
}

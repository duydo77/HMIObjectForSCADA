using System.Windows;
using System.Windows.Media;

namespace Pump
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
        private void ONButton_Click(object sender, RoutedEventArgs e)
        {
            Pump.Enable = true;
            Pump.Start();
            ONButton.Background = new SolidColorBrush(Colors.Red);
            OFFButton.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void OFFButton_Click(object sender, RoutedEventArgs e)
        {
            Pump.Enable = false;
            Pump.Start();
            OFFButton.Background = new SolidColorBrush(Colors.Red);
            ONButton.Background = new SolidColorBrush(Colors.LightGray);
        }
    }
}

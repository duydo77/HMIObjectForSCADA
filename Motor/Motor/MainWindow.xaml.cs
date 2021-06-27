using System.Windows;
using System.Windows.Media;
namespace Motor
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
    
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Motor.Enable = true;
            Motor.Start();
            ONButton.Background  = new SolidColorBrush(Colors.Red);
            OFFButton.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Motor.Enable = false;
            Motor.Start();
            OFFButton.Background = new SolidColorBrush(Colors.Red);
            ONButton.Background  = new SolidColorBrush(Colors.LightGray);
        }
    }
}
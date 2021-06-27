using System;
using System.Collections.Generic;
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

namespace HMI_SevenSegment
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int num = int.Parse(textBox.Text);
                sevenSeg.showDecimalNumber(num, (bool)radioButton.IsChecked);
                multi.showByHex(0, 0x30);
            }
            catch (Exception)
            {
                MessageBox.Show("invalid input!!!");
            }
        }

        private bool rdchecked = false;
        private void RB_clicked(object sender, RoutedEventArgs e)
        {
            rdchecked = !rdchecked;
            radioButton.IsChecked = rdchecked;
            
        }

        private void button_int_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int num = int.Parse(textBox_int.Text);
                multi.showByDecimalNumber(num);
            }
            catch (Exception)
            {
                MessageBox.Show("invalid input!!!");
            }
        }

        private void button_float_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                float num = float.Parse(textBox_float.Text);
                int acc = int.Parse(textBox_acc.Text);
                multi.showByFloatNumber(num, acc);
            }
            catch (Exception)
            {
                MessageBox.Show("invalid input!!!");
            }
        }
    }
}

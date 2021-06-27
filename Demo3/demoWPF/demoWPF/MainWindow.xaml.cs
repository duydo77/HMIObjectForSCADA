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

namespace demoWPF
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

        private void btn_motor_on_Click(object sender, RoutedEventArgs e)
        {
            motor.Enable = true;
            motor.Start();
        }

        private void btn_motor_off_Click(object sender, RoutedEventArgs e)
        {
            motor.Enable = false;
            motor.Start();
        }


        private void btn_pump_on_Click(object sender, RoutedEventArgs e)
        {
            pump.Enable = true;
            pump.Start();
        }

        private void btn_pump_off_Click(object sender, RoutedEventArgs e)
        {
            pump.Enable = false;
            pump.Start();
        }

        private void btn_tank_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int tankMin = int.Parse(txt_tank_min.Text);
                int tankMax = int.Parse(txt_tank_max.Text);
                int tankVal = int.Parse(txt_tank_val.Text);
                tank.level = tankVal;
                tank.maxi = tankMax;
                tank.mini = tankMin;
                tank.ChangeVal();
            }
            catch
            {
                MessageBox.Show("Input of gauge is not valid!!!");
            }

        }

        private void btn_gauge_set_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int gaugeVal = int.Parse(txt_gauge_val.Text);
                int gaugeMax = int.Parse(txt_gauge_max.Text);
                int gaugeMin = int.Parse(txt_gauge_min.Text);
                gauge.pointVal = gaugeVal*90/(gaugeMax-gaugeMin);
                gauge.changeVal();
            }
            catch
            {
                MessageBox.Show("Input of gauge is not valid!!!");
            }
        }

        private void btn_7seg_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int val = int.Parse(txt_7seg_val.Text);
                bool colon = (bool)rd_7seg.IsChecked;
                sevenSeg.showDecimalNumber(val, colon);
            }
            catch
            {
                MessageBox.Show("Input of seven segment is not valid!!!");
            }
        }

        bool rdchecked = false;
        private void rd_7seg_click(object sender, RoutedEventArgs e)
        {
            rdchecked = !rdchecked;
            rd_7seg.IsChecked = rdchecked; 
        }

        private void btn_multi_int_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int num = int.Parse(txt_multi_int.Text);
                multi.showByDecimalNumber(num);
            }
            catch (Exception)
            {
                MessageBox.Show("Input of seven segment multi is not valid!!!");
            }
        }

        private void btn_multi_float_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float num = float.Parse(txt_multi_float.Text);
                int acc = int.Parse(txt_multi_acc.Text);
                multi.showByFloatNumber(num, acc);
            }
            catch (Exception)
            {
                MessageBox.Show("Input of seven segment multi is not valid!!!");
            }
        }
    }
}

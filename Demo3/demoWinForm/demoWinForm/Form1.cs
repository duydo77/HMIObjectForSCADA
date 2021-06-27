using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            multi.NumberOfLed = 5;
            multi.BackgroundColor = System.Windows.Media.Color.FromRgb(0x3E, 0x3E, 0x3E);
            multi.LedOnColor = System.Windows.Media.Color.FromRgb(0x06, 0xE6, 0xD2);
            multi.LedOffColor = System.Windows.Media.Color.FromRgb(0x09, 0x03, 0x42);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sevenSegments1.showDecimalNumber(1, true);
        }

        private void btn_motor_on_Click(object sender, EventArgs e)
        {
            motor.Enable = true;
            motor.Start();
        }

        private void btn_motor_off_Click(object sender, EventArgs e)
        {
            motor.Enable = false;
            motor.Start();
        }

        private void btn_pump_on_Click(object sender, EventArgs e)
        {
            pump.Enable = true;
            pump.Start();
        }

        private void btn_pump_off_Click(object sender, EventArgs e)
        {
            pump.Enable = false;
            pump.Start();
        }

        private void btn_tank_Click(object sender, EventArgs e)
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
                MessageBox.Show("Input of tank is not valid!!!");
            }
        }

        private void btn_7seg_Click(object sender, EventArgs e)
        {
            try
            {
                int val = int.Parse(txt_7seg_val.Text);
                bool colon = rd_7seg.Checked;
                sevenSeg.showDecimalNumber(val, colon);
            }
            catch
            {
                MessageBox.Show("Input of seven segment is not valid!!!");
            }
        }

        private void btn_multi_int_Click(object sender, EventArgs e)
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

        private void btn_multi_float_Click(object sender, EventArgs e)
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

        bool rdchecked = false;

        private void rd_7seg_Click(object sender, EventArgs e)
        {
            rdchecked = !rdchecked;
            rd_7seg.Checked = rdchecked;
        }

        private void btn_gauge_Click(object sender, EventArgs e)
        {
            try
            {
                int gaugeVal = int.Parse(txt_gauge_val.Text);
                int gaugeMax = int.Parse(txt_gauge_max.Text);
                int gaugeMin = int.Parse(txt_gauge_min.Text);
                gauge1.pointVal = gaugeVal * 90 / (gaugeMax - gaugeMin);
                gauge1.changeVal();
            }
            catch
            {
                MessageBox.Show("Input of gauge is not valid!!!");
            }
        }
    }
}

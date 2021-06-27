using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAUGE
{
    public partial class Form1 : Form
    {
        int val;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gauge2.changeVal();

            Int32.TryParse(valPoint.Text, out val);
            gauge2.pointVal = val;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

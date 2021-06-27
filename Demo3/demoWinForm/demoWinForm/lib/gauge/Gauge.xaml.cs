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

namespace GAUGE
{
    /// <summary>
    /// Interaction logic for Gauge.xaml
    /// </summary>
    public partial class Gauge : UserControl
    {
        public double pointVal;
        public Gauge()
        {
            InitializeComponent();
        }
        public void changeVal()
        {
            RotateTransform rotate = new RotateTransform(pointVal);
            arrPoint.RenderTransform = rotate;
        }
    }
}

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

namespace HMITank
{
    /// <summary>
    /// Interaction logic for HMITankCtrl.xaml
    /// </summary>
    public partial class HMITankCtrl : UserControl
    {
        public bool _progressBarVisible = true;   
        public double level, maxi, mini;

        public bool ProcessBarVisible
        {
            get { return _progressBarVisible; }
            set
            {
                _progressBarVisible = value;
                if (value) ProcessBar.Visibility = Visibility.Visible;
                else ProcessBar.Visibility = Visibility.Hidden;
            }
        }

        public HMITankCtrl()
        {
            InitializeComponent();
        }

        public void ChangeVal()
        {
            ProcessBar.Value = level;
            ProcessBar.Maximum = maxi;
            ProcessBar.Minimum = mini;
        }
    }
}

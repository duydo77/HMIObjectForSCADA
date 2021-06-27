using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for SevenSegments.xaml
    /// </summary>
    public partial class SevenSegments : UserControl
    {
        private SolidColorBrush _backgroundColor = Brushes.Black;
        private SolidColorBrush _ledOffColor = new SolidColorBrush(Color.FromRgb(0x62, 0x00, 0x00)); 
        private SolidColorBrush _ledOnColor = Brushes.Red;
        private byte _hexVal = 0;
        private Boolean _colonVisibility = true;

        public SevenSegments()
        {
            InitializeComponent();
        }

        [Category("SevenSeg")]
        [Browsable(true)]
        [DisplayName("BackgroundColor")]
        public SolidColorBrush BackgroundColor
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value; canvas.Background = value; }
        }

        [Category("SevenSeg")]
        [Browsable(true)]
        [DisplayName("LedOnColor")]
        public SolidColorBrush LedOnColor
        {
            get { return _ledOnColor; }
            set { _ledOnColor = value; this.showHexNum(_hexVal); }
        }

        [Category("SevenSeg")]
        [Browsable(true)]
        [DisplayName("LedOffColor")]
        public SolidColorBrush LedOffColor
        {
            get { return _ledOffColor; }
            set { _ledOffColor = value; this.showHexNum(_hexVal); }
        }

        [Category("SevenSeg")]
        [Browsable(true)]
        [DisplayName("HexNum")]
        public byte HexNum
        {
            get { return _hexVal; }
            set
            {
                _hexVal = value;
                showHexNum(_hexVal);
            }
        }

        [Category("SevenSeg")]
        [Browsable(true)]
        [DisplayName("ColonVisibility")]
        public Boolean ColonVisibility
        {
            get { return _colonVisibility; }
            set
            {
                _colonVisibility = value;
                if (value)
                {
                    colon.Visibility = Visibility.Visible;
                }
                else
                {
                    colon.Visibility = Visibility.Hidden;
                }
            }
        }

        [Category("SevenSeg")]
        [Browsable(false)]
        [DisplayName("TurnOnColon")]
        public Boolean TurnOnColon
        {
            get { return ((_hexVal & 0x80) == 0); }
            set
            {
                if (value)
                {
                    //_hexVal = (byte)(_hexVal | 0x80);
                    colon.Fill = _ledOnColor;
                }
                else
                {
                    //_hexVal = (byte)(_hexVal & 0x7F);
                    colon.Fill = _ledOffColor;
                }
            }
        }

        public void showDecimalNumber(int value, bool turnOnColon)
        {

            if (value < -1 || value > 9)
            {
                throw new InvalidOperationException("argument is not right");
            }

            switch (value)
            {
                case 0:
                    _hexVal = (turnOnColon) ? (byte)(0x80 | 0x7E) : (byte)(0x7F & 0x7E);
                    break;
                case 1:
                    _hexVal = (turnOnColon) ? (byte)(0x80 | 0x30) : (byte)(0x7F & 0x30);
                    break;
                case 2:
                    _hexVal = (turnOnColon) ? (byte)(0x80 | 0x6D) : (byte)(0x7F & 0x6D);
                    break;
                case 3:
                    _hexVal = (turnOnColon) ? (byte)(0x80 | 0x79) : (byte)(0x7F & 0x79);
                    break;
                case 4:
                    _hexVal = (turnOnColon) ? (byte)(0x80 | 0x33) : (byte)(0x7F & 0x33);
                    break;
                case 5:
                    _hexVal = (turnOnColon) ? (byte)(0x80 | 0x5B) : (byte)(0x7F & 0x5B);
                    break;
                case 6:
                    _hexVal = (turnOnColon) ? (byte)(0x80 | 0x1F) : (byte)(0x7F & 0x1F);
                    break;
                case 7:
                    _hexVal = (turnOnColon) ? (byte)(0x80 | 0x70) : (byte)(0x7F & 0x70);
                    break;
                case 8:
                    _hexVal = (turnOnColon) ? (byte)(0x80 | 0x7F) : (byte)(0x7F & 0x7F);
                    break;
                case 9:
                    _hexVal = (turnOnColon) ? (byte)(0x80 | 0x73) : (byte)(0x7F & 0x73);
                    break;
                case -1:
                    _hexVal = (turnOnColon) ? (byte)(0x80 | 0x00) : (byte)(0x7F & 0x00);
                    break;
                default:
                    break;
            }
            // colon.Fill = (turnOnColon) ? _ledOnColor : _ledOffColor;
            showHexNum(_hexVal);
        }

        public void showHexNum(byte b)
        {
            // 1 2 4 8 16 32 64 128
            a_SEG.Fill = ((b & (byte)0x40) == 0) ? _ledOffColor : _ledOnColor;
            b_SEG.Fill = ((b & (byte)0x20) == 0) ? _ledOffColor : _ledOnColor;
            c_SEG.Fill = ((b & (byte)0x10) == 0) ? _ledOffColor : _ledOnColor;
            d_SEG.Fill = ((b & (byte)0x08) == 0) ? _ledOffColor : _ledOnColor;
            e_SEG.Fill = ((b & (byte)0x04) == 0) ? _ledOffColor : _ledOnColor;
            f_SEG.Fill = ((b & (byte)0x02) == 0) ? _ledOffColor : _ledOnColor;
            g_SEG.Fill = ((b & (byte)0x01) == 0) ? _ledOffColor : _ledOnColor;
            colon.Fill = ((b & (byte)0x80) == 0) ? _ledOffColor : _ledOnColor;
            _hexVal = b;
        }
    }
}

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
    /// Interaction logic for SevenSegmentsMulti.xaml
    /// </summary>
    public partial class SevenSegmentsMulti : UserControl
    {
        private int     _numberOfLed = 5;
        private Color   _backgroundColor = Color.FromRgb(0, 0, 0);
        private Color   _ledOnColor = Color.FromRgb(255, 0, 0);
        private Color   _ledOffColor = Color.FromRgb(0x62, 0, 0);
        private bool    _visibelAllColon = true;

        private List<SevenSegments> items = new List<SevenSegments>();

        public SevenSegmentsMulti()
        {
            InitializeComponent();
            canvas.Background = new SolidColorBrush(_backgroundColor);

            canvas.Width = 50 * _numberOfLed;
            for (int i = 0; i < _numberOfLed; i++)
            {
                SevenSegments newone = new SevenSegments
                {
                    Name = "led" + i.ToString(),
                    HorizontalAlignment = HorizontalAlignment.Left,
                    VerticalAlignment = VerticalAlignment.Top,
                    BackgroundColor = Brushes.Transparent
                };
                myStackPanel.Children.Add(newone);
            }
        }

        [Category("SevenSegMulti")]
        [Browsable(true)]
        [DisplayName("NumberOfLed")]
        public int NumberOfLed
        {
            get { return _numberOfLed; }
            set
            {
                if (value < 2 | value > 15)
                    throw new InvalidOperationException("Number of led should between 2 and 15!!!");
                myStackPanel.Children.Clear();

                canvas.Width = 50 * value;
                for (int i = 0; i < value; i++)
                {
                    SevenSegments newone = new SevenSegments
                    {
                        Name = "led" + i.ToString(),
                        HorizontalAlignment = HorizontalAlignment.Left,
                        VerticalAlignment = VerticalAlignment.Top,
                        BackgroundColor = Brushes.Transparent
                    };
                    myStackPanel.Children.Add(newone);
                }
                _numberOfLed = value;
            }
        }

        [Category("SevenSegMulti")]
        [Browsable(true)]
        [DisplayName("BackgroundColor")]
        public Color BackgroundColor
        {
            get { return _backgroundColor; }
            set
            {
                _backgroundColor = value;
                canvas.Background = new SolidColorBrush(_backgroundColor);
            }
        }

        [Category("SevenSegMulti")]
        [Browsable(true)]
        [DisplayName("LedOnColor")]
        public Color LedOnColor
        {
            get { return _ledOnColor; }
            set
            {
                _ledOnColor = value;
                foreach (var led in myStackPanel.Children) ((SevenSegments)led).LedOnColor = new SolidColorBrush(value);
            }
        }

        [Category("SevenSegMulti")]
        [Browsable(true)]
        [DisplayName("LedOffColor")]
        public Color LedOffColor
        {
            get { return _ledOffColor; }
            set
            {
                _ledOffColor = value;
                foreach (var led in myStackPanel.Children) ((SevenSegments)led).LedOffColor = new SolidColorBrush(value);
            }
        }

        [Category("SevenSegMulti")]
        [Browsable(true)]
        [DisplayName("VisibleAllColon")]
        public bool VisibleAllColon
        {
            get { return _visibelAllColon; }
            set
            {
                _visibelAllColon = value;
                VisibleColon(-1, value);
            }
        }

        public int _decNum;

        [Category("SevenSegMulti")]
        [Browsable(true)]
        [DisplayName("DecNumber")]
        public int DecNumber
        {
            get { return _decNum; }
            set
            {
                _decNum = value;
                showByDecimalNumber(value);
            }
        }

        public void showByDecimalNumber(int val, bool showZero = true)
        {
            for (int i = _numberOfLed - 1; i >= 0; i--)
            {
                int n = val % 10;
                val = val / 10;

                if (showZero & n == 0 & val == 0)
                {
                    ((SevenSegments)myStackPanel.Children[i]).showDecimalNumber(-1, false);
                    continue;
                }

                ((SevenSegments)myStackPanel.Children[i]).showDecimalNumber(n, false);
            }
        }

        public void showByFloatNumber(float f, int acc)
        {
            if (acc >= _numberOfLed) throw new InvalidOperationException("Accuracy is larger than number of led!!!");

            int num = (int)(f * Math.Pow(10, acc));
            showByDecimalNumber(num);
            turnOnColon(-1, false);
            turnOnColon(_numberOfLed - 1 - acc, true);
        }

        public void VisibleColon(int i, bool en)
        {
            if (i == -1)
            {
                foreach (var l in myStackPanel.Children)
                {
                    ((SevenSegments)l).ColonVisibility = en;
                }
                return;
            }

            if (i < 0 | i >= _numberOfLed)
                throw new InvalidOperationException("Index out of range!!!");

            ((SevenSegments)myStackPanel.Children[i]).ColonVisibility = en;
            this._visibelAllColon = false;
        }

        public void turnOnColon(int i, bool en)
        {
            if (i == -1)
            {
                foreach (var l in myStackPanel.Children)
                {
                    ((SevenSegments)l).TurnOnColon = en;
                }
                return;
            }

            if (i < 0 | i >= _numberOfLed)
                throw new InvalidOperationException("Index out of range!!!");

            ((SevenSegments)myStackPanel.Children[i]).TurnOnColon = en;
        }

        public void showByHexPerLed(int i, byte val)
        {
            if (i == -1)
            {
                foreach (var l in myStackPanel.Children)
                {
                    ((SevenSegments)l).showHexNum(val);
                }
                return;
            }

            if (i < 0 | i >= _numberOfLed)
                throw new InvalidOperationException("Index out of range!!!");

            ((SevenSegments)myStackPanel.Children[i]).showHexNum(val);
        }
    }
}

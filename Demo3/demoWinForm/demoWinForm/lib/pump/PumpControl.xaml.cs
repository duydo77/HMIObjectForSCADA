using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Pump
{   
    public partial class PumpControl : UserControl
    {
        public bool Enable; 
        public PumpControl()
        {
            InitializeComponent();
        }
        public void Start() 
        { 
            if (Enable == true)
            {
                RecColor_1.Color = Color.FromRgb(255, 0, 0);
                RecColor_2.Color = Color.FromRgb(255, 0, 0);
                RecColor_3.Color = Color.FromRgb(255, 0, 0);
                DoubleAnimation rotateAnimation_1 = new DoubleAnimation()
                {
                    From = 0,
                    To = 360,
                    Duration = new Duration(TimeSpan.FromSeconds(4))
                };
                var rotateTransform_x = new RotateTransform();
                rotateAnimation_1.RepeatBehavior = RepeatBehavior.Forever;
                Stick_1.RenderTransform = rotateTransform_x;
                rotateTransform_x.BeginAnimation(RotateTransform.AngleProperty, rotateAnimation_1);

                DoubleAnimation rotateAnimation_2 = new DoubleAnimation()
                {
                    From = 60,
                    To = 420,
                    Duration = new Duration(TimeSpan.FromSeconds(4))
                };
                var rotateTransform_2 = new RotateTransform();
                rotateAnimation_2.RepeatBehavior = RepeatBehavior.Forever;
                Stick_2.RenderTransform = rotateTransform_2;
                rotateTransform_2.BeginAnimation(RotateTransform.AngleProperty, rotateAnimation_2);

                DoubleAnimation rotateAnimation_3 = new DoubleAnimation()
                {
                    From = -60,
                    To = 300,
                    Duration = new Duration(TimeSpan.FromSeconds(4))
                };
                var rotateTransform_3 = new RotateTransform();
                rotateAnimation_3.RepeatBehavior = RepeatBehavior.Forever;
                Stick_3.RenderTransform = rotateTransform_3;
                rotateTransform_3.BeginAnimation(RotateTransform.AngleProperty, rotateAnimation_3);

            }
            else
           {
                RecColor_1.Color = Color.FromRgb(128, 128, 128);
                RecColor_2.Color = Color.FromRgb(128, 128, 128);
                RecColor_3.Color = Color.FromRgb(128, 128, 128);
                RotateTransform rotateTransform_1 = new RotateTransform(0);
                Stick_1.RenderTransform = rotateTransform_1;
                RotateTransform rotateTransform_2 = new RotateTransform(60);
                Stick_2.RenderTransform = rotateTransform_2;
                RotateTransform rotateTransform_3 = new RotateTransform(-60);
                Stick_3.RenderTransform = rotateTransform_3;
            }
        }
    }
}

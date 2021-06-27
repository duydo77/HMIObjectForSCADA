using System.Windows.Controls;
using System.Windows.Media;

namespace Motor
{
    public partial class ControlMotor : UserControl
    {
        public bool Enable; 
        public ControlMotor()
        {
            InitializeComponent();
        }
        public void Start() 
        {
            if (Enable == true) 
            {
                RecColor_4.Color = Color.FromRgb(255, 0, 0);
                RecColor_5.Color = Color.FromRgb(255, 0, 0);
                RecColor_6.Color = Color.FromRgb(255, 0, 0);
            }
            else     
            {
                RecColor_4.Color = Color.FromRgb(47, 79, 79);
                RecColor_5.Color = Color.FromRgb(47, 79, 79);
                RecColor_6.Color = Color.FromRgb(47, 79, 79);
            }

        }
    }
}


namespace demoWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_7seg = new System.Windows.Forms.Button();
            this.txt_7seg_val = new System.Windows.Forms.TextBox();
            this.rd_7seg = new System.Windows.Forms.RadioButton();
            this.txt_multi_float = new System.Windows.Forms.TextBox();
            this.btn_multi_float = new System.Windows.Forms.Button();
            this.txt_multi_acc = new System.Windows.Forms.TextBox();
            this.txt_multi_int = new System.Windows.Forms.TextBox();
            this.btn_multi_int = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_motor_on = new System.Windows.Forms.Button();
            this.btn_motor_off = new System.Windows.Forms.Button();
            this.btn_pump_off = new System.Windows.Forms.Button();
            this.btn_pump_on = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tank_max = new System.Windows.Forms.TextBox();
            this.txt_tank_min = new System.Windows.Forms.TextBox();
            this.btn_tank = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_gauge_max = new System.Windows.Forms.TextBox();
            this.txt_gauge_min = new System.Windows.Forms.TextBox();
            this.btn_gauge = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tank_val = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_gauge_val = new System.Windows.Forms.TextBox();
            this.elementHost6 = new System.Windows.Forms.Integration.ElementHost();
            this.gauge1 = new GAUGE.Gauge();
            this.elementHost5 = new System.Windows.Forms.Integration.ElementHost();
            this.pump = new Pump.PumpControl();
            this.elementHost4 = new System.Windows.Forms.Integration.ElementHost();
            this.motor = new Motor.ControlMotor();
            this.elementHost3 = new System.Windows.Forms.Integration.ElementHost();
            this.tank = new HMITank.HMITankCtrl();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.multi = new HMI_SevenSegment.SevenSegmentsMulti();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.sevenSeg = new HMI_SevenSegment.SevenSegments();
            this.SuspendLayout();
            // 
            // btn_7seg
            // 
            this.btn_7seg.Location = new System.Drawing.Point(203, 389);
            this.btn_7seg.Name = "btn_7seg";
            this.btn_7seg.Size = new System.Drawing.Size(75, 23);
            this.btn_7seg.TabIndex = 1;
            this.btn_7seg.Text = "Set";
            this.btn_7seg.UseVisualStyleBackColor = true;
            this.btn_7seg.Click += new System.EventHandler(this.btn_7seg_Click);
            // 
            // txt_7seg_val
            // 
            this.txt_7seg_val.Location = new System.Drawing.Point(204, 334);
            this.txt_7seg_val.Name = "txt_7seg_val";
            this.txt_7seg_val.Size = new System.Drawing.Size(75, 20);
            this.txt_7seg_val.TabIndex = 2;
            this.txt_7seg_val.Text = "0";
            // 
            // rd_7seg
            // 
            this.rd_7seg.AutoSize = true;
            this.rd_7seg.Location = new System.Drawing.Point(204, 364);
            this.rd_7seg.Name = "rd_7seg";
            this.rd_7seg.Size = new System.Drawing.Size(51, 17);
            this.rd_7seg.TabIndex = 4;
            this.rd_7seg.TabStop = true;
            this.rd_7seg.Text = "colon";
            this.rd_7seg.UseVisualStyleBackColor = true;
            this.rd_7seg.Click += new System.EventHandler(this.rd_7seg_Click);
            // 
            // txt_multi_float
            // 
            this.txt_multi_float.Location = new System.Drawing.Point(509, 436);
            this.txt_multi_float.Name = "txt_multi_float";
            this.txt_multi_float.Size = new System.Drawing.Size(62, 20);
            this.txt_multi_float.TabIndex = 6;
            this.txt_multi_float.Text = "12.345";
            // 
            // btn_multi_float
            // 
            this.btn_multi_float.Location = new System.Drawing.Point(509, 491);
            this.btn_multi_float.Name = "btn_multi_float";
            this.btn_multi_float.Size = new System.Drawing.Size(62, 23);
            this.btn_multi_float.TabIndex = 5;
            this.btn_multi_float.Text = "Set";
            this.btn_multi_float.UseVisualStyleBackColor = true;
            this.btn_multi_float.Click += new System.EventHandler(this.btn_multi_float_Click);
            // 
            // txt_multi_acc
            // 
            this.txt_multi_acc.Location = new System.Drawing.Point(509, 462);
            this.txt_multi_acc.Name = "txt_multi_acc";
            this.txt_multi_acc.Size = new System.Drawing.Size(62, 20);
            this.txt_multi_acc.TabIndex = 7;
            this.txt_multi_acc.Text = "3";
            // 
            // txt_multi_int
            // 
            this.txt_multi_int.Location = new System.Drawing.Point(384, 435);
            this.txt_multi_int.Name = "txt_multi_int";
            this.txt_multi_int.Size = new System.Drawing.Size(62, 20);
            this.txt_multi_int.TabIndex = 9;
            this.txt_multi_int.Text = "1111";
            // 
            // btn_multi_int
            // 
            this.btn_multi_int.Location = new System.Drawing.Point(384, 490);
            this.btn_multi_int.Name = "btn_multi_int";
            this.btn_multi_int.Size = new System.Drawing.Size(62, 23);
            this.btn_multi_int.TabIndex = 8;
            this.btn_multi_int.Text = "Set";
            this.btn_multi_int.UseVisualStyleBackColor = true;
            this.btn_multi_int.Click += new System.EventHandler(this.btn_multi_int_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Int value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Float value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Acc";
            // 
            // btn_motor_on
            // 
            this.btn_motor_on.Location = new System.Drawing.Point(204, 29);
            this.btn_motor_on.Name = "btn_motor_on";
            this.btn_motor_on.Size = new System.Drawing.Size(75, 23);
            this.btn_motor_on.TabIndex = 18;
            this.btn_motor_on.Text = "On";
            this.btn_motor_on.UseVisualStyleBackColor = true;
            this.btn_motor_on.Click += new System.EventHandler(this.btn_motor_on_Click);
            // 
            // btn_motor_off
            // 
            this.btn_motor_off.Location = new System.Drawing.Point(204, 58);
            this.btn_motor_off.Name = "btn_motor_off";
            this.btn_motor_off.Size = new System.Drawing.Size(75, 23);
            this.btn_motor_off.TabIndex = 19;
            this.btn_motor_off.Text = "Off";
            this.btn_motor_off.UseVisualStyleBackColor = true;
            this.btn_motor_off.Click += new System.EventHandler(this.btn_motor_off_Click);
            // 
            // btn_pump_off
            // 
            this.btn_pump_off.Location = new System.Drawing.Point(546, 58);
            this.btn_pump_off.Name = "btn_pump_off";
            this.btn_pump_off.Size = new System.Drawing.Size(75, 23);
            this.btn_pump_off.TabIndex = 21;
            this.btn_pump_off.Text = "Off";
            this.btn_pump_off.UseVisualStyleBackColor = true;
            this.btn_pump_off.Click += new System.EventHandler(this.btn_pump_off_Click);
            // 
            // btn_pump_on
            // 
            this.btn_pump_on.Location = new System.Drawing.Point(546, 29);
            this.btn_pump_on.Name = "btn_pump_on";
            this.btn_pump_on.Size = new System.Drawing.Size(75, 23);
            this.btn_pump_on.TabIndex = 20;
            this.btn_pump_on.Text = "On";
            this.btn_pump_on.UseVisualStyleBackColor = true;
            this.btn_pump_on.Click += new System.EventHandler(this.btn_pump_on_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Min";
            // 
            // txt_tank_max
            // 
            this.txt_tank_max.Location = new System.Drawing.Point(216, 203);
            this.txt_tank_max.Name = "txt_tank_max";
            this.txt_tank_max.Size = new System.Drawing.Size(62, 20);
            this.txt_tank_max.TabIndex = 24;
            this.txt_tank_max.Text = "100";
            // 
            // txt_tank_min
            // 
            this.txt_tank_min.Location = new System.Drawing.Point(216, 158);
            this.txt_tank_min.Name = "txt_tank_min";
            this.txt_tank_min.Size = new System.Drawing.Size(62, 20);
            this.txt_tank_min.TabIndex = 23;
            this.txt_tank_min.Text = "0";
            // 
            // btn_tank
            // 
            this.btn_tank.Location = new System.Drawing.Point(216, 268);
            this.btn_tank.Name = "btn_tank";
            this.btn_tank.Size = new System.Drawing.Size(62, 23);
            this.btn_tank.TabIndex = 22;
            this.btn_tank.Text = "Set";
            this.btn_tank.UseVisualStyleBackColor = true;
            this.btn_tank.Click += new System.EventHandler(this.btn_tank_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(543, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(543, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Min";
            // 
            // txt_gauge_max
            // 
            this.txt_gauge_max.Location = new System.Drawing.Point(546, 203);
            this.txt_gauge_max.Name = "txt_gauge_max";
            this.txt_gauge_max.Size = new System.Drawing.Size(62, 20);
            this.txt_gauge_max.TabIndex = 29;
            this.txt_gauge_max.Text = "100";
            // 
            // txt_gauge_min
            // 
            this.txt_gauge_min.Location = new System.Drawing.Point(546, 158);
            this.txt_gauge_min.Name = "txt_gauge_min";
            this.txt_gauge_min.Size = new System.Drawing.Size(62, 20);
            this.txt_gauge_min.TabIndex = 28;
            this.txt_gauge_min.Text = "0";
            // 
            // btn_gauge
            // 
            this.btn_gauge.Location = new System.Drawing.Point(546, 268);
            this.btn_gauge.Name = "btn_gauge";
            this.btn_gauge.Size = new System.Drawing.Size(62, 23);
            this.btn_gauge.TabIndex = 27;
            this.btn_gauge.Text = "Set";
            this.btn_gauge.UseVisualStyleBackColor = true;
            this.btn_gauge.Click += new System.EventHandler(this.btn_gauge_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Val";
            // 
            // txt_tank_val
            // 
            this.txt_tank_val.Location = new System.Drawing.Point(216, 242);
            this.txt_tank_val.Name = "txt_tank_val";
            this.txt_tank_val.Size = new System.Drawing.Size(62, 20);
            this.txt_tank_val.TabIndex = 32;
            this.txt_tank_val.Text = "50";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(544, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Val";
            // 
            // txt_gauge_val
            // 
            this.txt_gauge_val.Location = new System.Drawing.Point(546, 242);
            this.txt_gauge_val.Name = "txt_gauge_val";
            this.txt_gauge_val.Size = new System.Drawing.Size(62, 20);
            this.txt_gauge_val.TabIndex = 34;
            this.txt_gauge_val.Text = "0";
            // 
            // elementHost6
            // 
            this.elementHost6.Location = new System.Drawing.Point(372, 142);
            this.elementHost6.Margin = new System.Windows.Forms.Padding(2);
            this.elementHost6.Name = "elementHost6";
            this.elementHost6.Size = new System.Drawing.Size(128, 148);
            this.elementHost6.TabIndex = 36;
            this.elementHost6.Text = "elementHost6";
            this.elementHost6.Child = this.gauge1;
            // 
            // elementHost5
            // 
            this.elementHost5.Location = new System.Drawing.Point(358, 12);
            this.elementHost5.Name = "elementHost5";
            this.elementHost5.Size = new System.Drawing.Size(168, 100);
            this.elementHost5.TabIndex = 17;
            this.elementHost5.Text = "elementHost5";
            this.elementHost5.Child = this.pump;
            // 
            // elementHost4
            // 
            this.elementHost4.Location = new System.Drawing.Point(38, 12);
            this.elementHost4.Name = "elementHost4";
            this.elementHost4.Size = new System.Drawing.Size(146, 100);
            this.elementHost4.TabIndex = 16;
            this.elementHost4.Text = "elementHost4";
            this.elementHost4.Child = this.motor;
            // 
            // elementHost3
            // 
            this.elementHost3.Location = new System.Drawing.Point(38, 118);
            this.elementHost3.Name = "elementHost3";
            this.elementHost3.Size = new System.Drawing.Size(146, 200);
            this.elementHost3.TabIndex = 15;
            this.elementHost3.Text = "elementHost3";
            this.elementHost3.Child = this.tank;
            // 
            // elementHost2
            // 
            this.elementHost2.Location = new System.Drawing.Point(336, 313);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(258, 100);
            this.elementHost2.TabIndex = 14;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.Child = this.multi;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(55, 324);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(116, 100);
            this.elementHost1.TabIndex = 13;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.sevenSeg;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 534);
            this.Controls.Add(this.elementHost6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_gauge_val);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_tank_val);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_gauge_max);
            this.Controls.Add(this.txt_gauge_min);
            this.Controls.Add(this.btn_gauge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tank_max);
            this.Controls.Add(this.txt_tank_min);
            this.Controls.Add(this.btn_tank);
            this.Controls.Add(this.btn_pump_off);
            this.Controls.Add(this.btn_pump_on);
            this.Controls.Add(this.btn_motor_off);
            this.Controls.Add(this.btn_motor_on);
            this.Controls.Add(this.elementHost5);
            this.Controls.Add(this.elementHost4);
            this.Controls.Add(this.elementHost3);
            this.Controls.Add(this.elementHost2);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_multi_int);
            this.Controls.Add(this.btn_multi_int);
            this.Controls.Add(this.txt_multi_acc);
            this.Controls.Add(this.txt_multi_float);
            this.Controls.Add(this.btn_multi_float);
            this.Controls.Add(this.rd_7seg);
            this.Controls.Add(this.txt_7seg_val);
            this.Controls.Add(this.btn_7seg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_7seg;
        private System.Windows.Forms.TextBox txt_7seg_val;
        private System.Windows.Forms.RadioButton rd_7seg;
        private System.Windows.Forms.TextBox txt_multi_float;
        private System.Windows.Forms.Button btn_multi_float;
        private System.Windows.Forms.TextBox txt_multi_acc;
        private System.Windows.Forms.TextBox txt_multi_int;
        private System.Windows.Forms.Button btn_multi_int;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private HMI_SevenSegment.SevenSegments sevenSeg;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private HMI_SevenSegment.SevenSegmentsMulti multi;
        private System.Windows.Forms.Integration.ElementHost elementHost3;
        private HMITank.HMITankCtrl tank;
        private System.Windows.Forms.Integration.ElementHost elementHost4;
        private Motor.ControlMotor motor;
        private System.Windows.Forms.Integration.ElementHost elementHost5;
        private Pump.PumpControl pump;
        private System.Windows.Forms.Button btn_motor_on;
        private System.Windows.Forms.Button btn_motor_off;
        private System.Windows.Forms.Button btn_pump_off;
        private System.Windows.Forms.Button btn_pump_on;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tank_max;
        private System.Windows.Forms.TextBox txt_tank_min;
        private System.Windows.Forms.Button btn_tank;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_gauge_max;
        private System.Windows.Forms.TextBox txt_gauge_min;
        private System.Windows.Forms.Button btn_gauge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tank_val;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_gauge_val;
        private System.Windows.Forms.Integration.ElementHost elementHost6;
        private GAUGE.Gauge gauge1;
    }
}


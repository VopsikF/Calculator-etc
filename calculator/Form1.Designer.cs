namespace calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.background1 = new calculator.Background();
            this.buttonRed2 = new calculator.ButtonRed();
            this.button6 = new calculator.Button();
            this.button2 = new calculator.Button();
            this.textBox12 = new calculator.TextBox1();
            this.textBox11 = new calculator.TextBox1();
            this.button211 = new calculator.Button2();
            this.button210 = new calculator.Button2();
            this.button29 = new calculator.Button2();
            this.button28 = new calculator.Button2();
            this.button27 = new calculator.Button2();
            this.button26 = new calculator.Button2();
            this.button25 = new calculator.Button2();
            this.button24 = new calculator.Button2();
            this.button23 = new calculator.Button2();
            this.button22 = new calculator.Button2();
            this.button21 = new calculator.Button2();
            this.buttonRed1 = new calculator.ButtonRed();
            this.button13 = new calculator.Button();
            this.button14 = new calculator.Button();
            this.button15 = new calculator.Button();
            this.button16 = new calculator.Button();
            this.button3 = new calculator.Button();
            this.button4 = new calculator.Button();
            this.button10 = new calculator.Button();
            this.button11 = new calculator.Button();
            this.button8 = new calculator.Button();
            this.button7 = new calculator.Button();
            this.button5 = new calculator.Button();
            this.button1 = new calculator.Button();
            this.background1.SuspendLayout();
            this.SuspendLayout();
            // 
            // background1
            // 
            this.background1.ColorBottom = System.Drawing.Color.DarkRed;
            this.background1.ColorTop = System.Drawing.Color.Black;
            this.background1.Controls.Add(this.buttonRed2);
            this.background1.Controls.Add(this.button6);
            this.background1.Controls.Add(this.button2);
            this.background1.Controls.Add(this.textBox12);
            this.background1.Controls.Add(this.textBox11);
            this.background1.Controls.Add(this.button211);
            this.background1.Controls.Add(this.button210);
            this.background1.Controls.Add(this.button29);
            this.background1.Controls.Add(this.button28);
            this.background1.Controls.Add(this.button27);
            this.background1.Controls.Add(this.button26);
            this.background1.Controls.Add(this.button25);
            this.background1.Controls.Add(this.button24);
            this.background1.Controls.Add(this.button23);
            this.background1.Controls.Add(this.button22);
            this.background1.Controls.Add(this.button21);
            this.background1.Controls.Add(this.buttonRed1);
            this.background1.Controls.Add(this.button13);
            this.background1.Controls.Add(this.button14);
            this.background1.Controls.Add(this.button15);
            this.background1.Controls.Add(this.button16);
            this.background1.Controls.Add(this.button3);
            this.background1.Controls.Add(this.button4);
            this.background1.Controls.Add(this.button10);
            this.background1.Controls.Add(this.button11);
            this.background1.Controls.Add(this.button8);
            this.background1.Controls.Add(this.button7);
            this.background1.Controls.Add(this.button5);
            this.background1.Controls.Add(this.button1);
            this.background1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background1.Location = new System.Drawing.Point(0, 0);
            this.background1.Name = "background1";
            this.background1.Size = new System.Drawing.Size(578, 744);
            this.background1.TabIndex = 1;
            // 
            // buttonRed2
            // 
            this.buttonRed2.BackColor = System.Drawing.Color.Maroon;
            this.buttonRed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonRed2.ForeColor = System.Drawing.Color.White;
            this.buttonRed2.Location = new System.Drawing.Point(516, 12);
            this.buttonRed2.Name = "buttonRed2";
            this.buttonRed2.Size = new System.Drawing.Size(50, 50);
            this.buttonRed2.TabIndex = 50;
            this.buttonRed2.Text = "?";
            this.buttonRed2.Click += new System.EventHandler(this.buttonRed2_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(68, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 47;
            this.button6.Text = "01";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 46;
            this.button2.Text = "$";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.Transparent;
            this.textBox12.ForeColor = System.Drawing.Color.White;
            this.textBox12.Location = new System.Drawing.Point(358, 79);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(208, 54);
            this.textBox12.TabIndex = 45;
            this.textBox12.Text = "textBox12";
            this.textBox12.TextBoxText = "";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.Transparent;
            this.textBox11.ForeColor = System.Drawing.Color.White;
            this.textBox11.Location = new System.Drawing.Point(12, 139);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(555, 85);
            this.textBox11.TabIndex = 44;
            this.textBox11.Text = "textBox11";
            this.textBox11.TextBoxText = "";
            // 
            // button211
            // 
            this.button211.BackColor = System.Drawing.Color.Transparent;
            this.button211.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.button211.ForeColor = System.Drawing.Color.White;
            this.button211.Location = new System.Drawing.Point(294, 333);
            this.button211.Name = "button211";
            this.button211.Size = new System.Drawing.Size(135, 75);
            this.button211.TabIndex = 41;
            this.button211.Text = "√";
            this.button211.Click += new System.EventHandler(this.button211_Click);
            // 
            // button210
            // 
            this.button210.BackColor = System.Drawing.Color.Transparent;
            this.button210.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.button210.ForeColor = System.Drawing.Color.White;
            this.button210.Location = new System.Drawing.Point(153, 333);
            this.button210.Name = "button210";
            this.button210.Size = new System.Drawing.Size(135, 75);
            this.button210.TabIndex = 40;
            this.button210.Text = "x²";
            this.button210.Click += new System.EventHandler(this.button210_Click);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.Transparent;
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.button29.ForeColor = System.Drawing.Color.White;
            this.button29.Location = new System.Drawing.Point(12, 333);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(135, 75);
            this.button29.TabIndex = 39;
            this.button29.Text = "⅟×";
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.Transparent;
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.button28.ForeColor = System.Drawing.Color.White;
            this.button28.Location = new System.Drawing.Point(12, 252);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(135, 75);
            this.button28.TabIndex = 38;
            this.button28.Text = "%";
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.Transparent;
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.button27.ForeColor = System.Drawing.Color.White;
            this.button27.Location = new System.Drawing.Point(153, 252);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(135, 75);
            this.button27.TabIndex = 37;
            this.button27.Text = "CE";
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.Transparent;
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.button26.ForeColor = System.Drawing.Color.White;
            this.button26.Location = new System.Drawing.Point(294, 252);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(135, 75);
            this.button26.TabIndex = 36;
            this.button26.Text = "C";
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.Transparent;
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.button25.ForeColor = System.Drawing.Color.White;
            this.button25.Location = new System.Drawing.Point(431, 252);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(135, 75);
            this.button25.TabIndex = 35;
            this.button25.Text = "⬅";
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.Transparent;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.button24.ForeColor = System.Drawing.Color.White;
            this.button24.Location = new System.Drawing.Point(435, 333);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(135, 75);
            this.button24.TabIndex = 34;
            this.button24.Text = "÷";
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Transparent;
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.button23.ForeColor = System.Drawing.Color.White;
            this.button23.Location = new System.Drawing.Point(435, 414);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(135, 75);
            this.button23.TabIndex = 33;
            this.button23.Text = "×";
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Transparent;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.button22.ForeColor = System.Drawing.Color.White;
            this.button22.Location = new System.Drawing.Point(435, 495);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(135, 75);
            this.button22.TabIndex = 32;
            this.button22.Text = "-";
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Transparent;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.button21.ForeColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(435, 576);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(135, 75);
            this.button21.TabIndex = 31;
            this.button21.Text = "+";
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // buttonRed1
            // 
            this.buttonRed1.BackColor = System.Drawing.Color.Maroon;
            this.buttonRed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.buttonRed1.ForeColor = System.Drawing.Color.White;
            this.buttonRed1.Location = new System.Drawing.Point(435, 657);
            this.buttonRed1.Name = "buttonRed1";
            this.buttonRed1.Size = new System.Drawing.Size(135, 75);
            this.buttonRed1.TabIndex = 30;
            this.buttonRed1.Text = "=";
            this.buttonRed1.Click += new System.EventHandler(this.buttonRed1_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Transparent;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(294, 657);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(135, 75);
            this.button13.TabIndex = 17;
            this.button13.Text = ",";
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Transparent;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(294, 414);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(135, 75);
            this.button14.TabIndex = 16;
            this.button14.Text = "9";
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Transparent;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(294, 495);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(135, 75);
            this.button15.TabIndex = 15;
            this.button15.Text = "6";
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Transparent;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(294, 576);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(135, 75);
            this.button16.TabIndex = 14;
            this.button16.Text = "3";
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(153, 657);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 75);
            this.button3.TabIndex = 12;
            this.button3.Text = "0";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(153, 414);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 75);
            this.button4.TabIndex = 11;
            this.button4.Text = "8";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(153, 495);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(135, 75);
            this.button10.TabIndex = 10;
            this.button10.Text = "5";
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(153, 576);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(135, 75);
            this.button11.TabIndex = 9;
            this.button11.Text = "2";
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(12, 657);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(135, 75);
            this.button8.TabIndex = 7;
            this.button8.Text = "+/-";
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(12, 414);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(135, 75);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(12, 495);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 75);
            this.button5.TabIndex = 4;
            this.button5.Text = "4";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 576);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(578, 744);
            this.Controls.Add(this.background1);
            this.MaximumSize = new System.Drawing.Size(600, 800);
            this.MinimumSize = new System.Drawing.Size(600, 800);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.background1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Background background1;
        private Button button1;
        private Button button5;
        private Button button8;
        private Button button7;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button3;
        private Button button4;
        private Button button10;
        private Button button11;
        private ButtonRed buttonRed1;
        private Button2 button21;
        private Button2 button211;
        private Button2 button210;
        private Button2 button29;
        private Button2 button28;
        private Button2 button27;
        private Button2 button26;
        private Button2 button25;
        private Button2 button24;
        private Button2 button23;
        private Button2 button22;
        private TextBox1 textBox11;
        private TextBox1 textBox12;
        private Button button2;
        private Button button6;
        private ButtonRed buttonRed2;
    }
}


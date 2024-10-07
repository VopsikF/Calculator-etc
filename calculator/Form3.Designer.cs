namespace calculator
{
    partial class Form3
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
            this.background1 = new calculator.Background();
            this.buttonRed2 = new calculator.ButtonRed();
            this.textBox31 = new calculator.TextBox3();
            this.button5 = new calculator.Button();
            this.button4 = new calculator.Button();
            this.button3 = new calculator.Button();
            this.textBox11 = new calculator.TextBox1();
            this.button2 = new calculator.Button();
            this.button1 = new calculator.Button();
            this.background1.SuspendLayout();
            this.SuspendLayout();
            // 
            // background1
            // 
            this.background1.ColorBottom = System.Drawing.Color.DarkRed;
            this.background1.ColorTop = System.Drawing.Color.Black;
            this.background1.Controls.Add(this.buttonRed2);
            this.background1.Controls.Add(this.textBox31);
            this.background1.Controls.Add(this.button5);
            this.background1.Controls.Add(this.button4);
            this.background1.Controls.Add(this.button3);
            this.background1.Controls.Add(this.textBox11);
            this.background1.Controls.Add(this.button2);
            this.background1.Controls.Add(this.button1);
            this.background1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background1.Location = new System.Drawing.Point(0, 0);
            this.background1.Name = "background1";
            this.background1.Size = new System.Drawing.Size(578, 744);
            this.background1.TabIndex = 0;
            // 
            // buttonRed2
            // 
            this.buttonRed2.BackColor = System.Drawing.Color.Maroon;
            this.buttonRed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonRed2.ForeColor = System.Drawing.Color.White;
            this.buttonRed2.Location = new System.Drawing.Point(516, 12);
            this.buttonRed2.Name = "buttonRed2";
            this.buttonRed2.Size = new System.Drawing.Size(50, 50);
            this.buttonRed2.TabIndex = 53;
            this.buttonRed2.Text = "?";
            this.buttonRed2.Click += new System.EventHandler(this.buttonRed2_Click);
            // 
            // textBox31
            // 
            this.textBox31.BackColor = System.Drawing.Color.Transparent;
            this.textBox31.ForeColor = System.Drawing.Color.White;
            this.textBox31.Location = new System.Drawing.Point(12, 103);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(555, 85);
            this.textBox31.TabIndex = 52;
            this.textBox31.Text = "textBox31";
            this.textBox31.TextBoxText = "";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(12, 338);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(554, 66);
            this.button5.TabIndex = 51;
            this.button5.Text = "hexadecimal system";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(11, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(554, 66);
            this.button4.TabIndex = 50;
            this.button4.Text = "decimal system";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(12, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(554, 66);
            this.button3.TabIndex = 49;
            this.button3.Text = "binary system";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.Transparent;
            this.textBox11.ForeColor = System.Drawing.Color.White;
            this.textBox11.Location = new System.Drawing.Point(13, 410);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(554, 69);
            this.textBox11.TabIndex = 48;
            this.textBox11.Text = "textBox11";
            this.textBox11.TextBoxText = "";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(68, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 47;
            this.button2.Text = "$";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "±";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 744);
            this.Controls.Add(this.background1);
            this.MaximumSize = new System.Drawing.Size(600, 800);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.background1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Background background1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox1 textBox11;
        private Button button5;
        private Button button4;
        private TextBox3 textBox31;
        private ButtonRed buttonRed2;
    }
}
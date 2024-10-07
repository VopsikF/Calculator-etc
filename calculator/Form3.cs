using System;
using System.Windows.Forms;


namespace calculator
{
    public partial class Form3 : Form
    {
        private Form1 form1;
        private Form2 form2;

        public Form3(Form1 form1, Form2 form2)
        {
            this.form1 = form1;
            this.form2 = form2;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(form1);
            form2.Show();
            this.Hide();
        }

        // Convert to binary system
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(textBox31.TextBoxText);
                string binary = Convert.ToString(number, 2);
                textBox11.TextBoxText = "0b" + binary;
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter the correct number.");
            }
        }

        // Convert to decimal system
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string input = textBox31.TextBoxText;
                if (input.StartsWith("0x"))
                {
                    // Hexadecimal to Decimal
                    int number = Convert.ToInt32(input, 16);
                    textBox11.TextBoxText = number.ToString();
                }
                else if (input.StartsWith("0b"))
                {
                    // Binary to Decimal
                    int number = Convert.ToInt32(input.Substring(2), 2);
                    textBox11.TextBoxText = number.ToString();
                }
                else
                {
                    textBox11.TextBoxText = "Incorrect number format.";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter the correct number.");
            }
        }

        // Convert to hexadecimal system
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(textBox31.TextBoxText);
                string hex = Convert.ToString(number, 16).ToUpper();
                textBox11.TextBoxText = "0x" + hex;
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter the correct number.");
            }
        }

        private void buttonRed2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ввод через клавиатуру. " +
                "В Binary префикс 0b - обозначает, что система бинарная(двоичная) " +
                "В hexadecimal префикс 0x - обозначает, что система шестнадцатеричная " +
                "При переводе чисел в десятичную систему введите префикс 0b или 0x " +
                "Нажав лкм по полю - скопируется содержимое");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

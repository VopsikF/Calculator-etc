using System;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operation = "";
        bool isOperationPerformed = false;
        private Form2 form2;
        public Form1()
        {
            InitializeComponent();
        }

        // Number button clicks
        private void button1_Click(object sender, EventArgs e) => AppendDigit("1");
        private void button11_Click(object sender, EventArgs e) => AppendDigit("2");
        private void button16_Click(object sender, EventArgs e) => AppendDigit("3");
        private void button5_Click(object sender, EventArgs e) => AppendDigit("4");
        private void button10_Click(object sender, EventArgs e) => AppendDigit("5");
        private void button15_Click(object sender, EventArgs e) => AppendDigit("6");
        private void button7_Click(object sender, EventArgs e) => AppendDigit("7");
        private void button4_Click(object sender, EventArgs e) => AppendDigit("8");
        private void button14_Click(object sender, EventArgs e) => AppendDigit("9");
        private void button3_Click(object sender, EventArgs e) => AppendDigit("0");

        // Functionality for appending digits to the textbox
        private void AppendDigit(string digit)
        {
            if (textBox11.TextBoxText == "0" || isOperationPerformed)
                textBox11.Clear();

            isOperationPerformed = false;
            textBox11.TextBoxText += digit;
            textBox12.TextBoxText += digit;
        }

        // Decimal point button click
        private void button13_Click(object sender, EventArgs e)
        {
            if (!textBox11.TextBoxText.Contains("."))
                textBox11.TextBoxText += ".";
        }

        // Operator button clicks
        private void button21_Click(object sender, EventArgs e) => SetOperation("+");
        private void button22_Click(object sender, EventArgs e) => SetOperation("-");
        private void button23_Click(object sender, EventArgs e) => SetOperation("*");
        private void button24_Click(object sender, EventArgs e) => SetOperation("/");
        private void button28_Click(object sender, EventArgs e) => SetOperation("%");

        // Set the operation based on button click
        private void SetOperation(string operationText)
        {
            if (double.TryParse(textBox11.TextBoxText.Trim(), out double parsedValue))
            {
                result = parsedValue;
                operation = operationText;
                textBox11.Clear();
                textBox12.TextBoxText += operationText;
                isOperationPerformed = true;
            }
            else
            {
                MessageBox.Show("Введено некорректное значение!");
            }
        }

        // Perform the calculation when '=' is pressed
        private void buttonRed1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox11.TextBoxText.Trim(), out double number))
            {
                performOperation(number);
                textBox12.TextBoxText += "=" + result.ToString();
                isOperationPerformed = false;
                textBox12.TextBoxText = result.ToString();
            }
            else
            {
                MessageBox.Show("Введено некорректное значение!");
            }
        }

        // Perform the operation based on the current operation
        private void performOperation(double number)
        {
            switch (operation)
            {
                case "+": result += number; break;
                case "-": result -= number; break;
                case "*": result *= number; break;
                case "/":
                    if (number != 0) result /= number;
                    else MessageBox.Show("На ноль делить нельзя!");
                    break;
                case "%": result = (result * number) / 100; break;
                default: MessageBox.Show("Неизвестная операция!"); break;
            }
            textBox11.TextBoxText = result.ToString();
            textBox12.TextBoxText += number.ToString();
        }

        // sqrt button
        private void button211_Click(object sender, EventArgs e) 
        {
            if (double.TryParse(textBox11.TextBoxText.Trim(), out double parsedValue))
            {
                if (parsedValue >= 0)
                {
                    result = Math.Sqrt(parsedValue);
                    textBox11.TextBoxText = result.ToString();
                    textBox12.TextBoxText = $"sqrt({parsedValue}) = {result}";
                }
                else
                {
                    MessageBox.Show("Невозможно вычислить квадратный корень из отрицательного числа!");
                }
            }
            else
            {
                MessageBox.Show("Введено некорректное значение!");
            }
        }

        // x^2 button
        private void button210_Click(object sender, EventArgs e) 
        {
            if (double.TryParse(textBox11.TextBoxText.Trim(), out double parsedValue))
            {
                result = Math.Pow(parsedValue, 2);
                textBox11.TextBoxText = result.ToString();
                textBox12.TextBoxText = $"{parsedValue}^2 = {result}";
            }
            else
            {
                MessageBox.Show("Введено некорректное значение!");
            }
        }

        //button 1/x
        private void button29_Click(object sender, EventArgs e) 
        {
            if (double.TryParse(textBox11.TextBoxText.Trim(), out double parsedValue))
            {
                if (parsedValue != 0)
                {
                    result = 1 / parsedValue;
                    textBox11.TextBoxText = result.ToString();
                    textBox12.TextBoxText = $"1/{parsedValue} = {result}";
                }
                else
                {
                    MessageBox.Show("Невозможно вычислить 1/0!");
                }
            }
            else
            {
                MessageBox.Show("Введено некорректное значение!");
            }
        }

        // +/- button
        private void button8_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox11.TextBoxText.Trim(), out double parsedValue))
            {
                result = -parsedValue;
                textBox11.TextBoxText = result.ToString();
                textBox12.TextBoxText = $"±({parsedValue}) = {result}";
            }
            else
            {
                MessageBox.Show("Введено некорректное значение!");
            }
        }

        //Backspace
        private void button25_Click(object sender, EventArgs e) 
        {
            if (textBox11.TextBoxText.Length > 0)
                textBox11.TextBoxText = textBox11.TextBoxText.Substring(0, textBox11.TextBoxText.Length - 1);

            if (textBox12.TextBoxText.Length > 0)
                textBox12.TextBoxText = textBox12.TextBoxText.Substring(0, textBox12.TextBoxText.Length - 1);
        }

        private void button27_Click(object sender, EventArgs e) => textBox11.Clear(); 
        private void button26_Click(object sender, EventArgs e) 
        {
            result = 0;
            operation = "";
            textBox11.Clear();
            textBox12.Clear();
            isOperationPerformed = false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            this.Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3(this, form2); 
            form3.Show();
            this.Hide();
        }

        private void buttonRed2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В данном калькуляторе работают все доступные функции." +
                " Ввод с клавиатуры работает только на цифры." +
                " Так-же слева сверху можно переключаться между двумя другими програмамми." +
                " Нажав лкм по полю - скопируется содержимое");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

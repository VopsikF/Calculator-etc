using System;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form2 : Form
    {
        private Form1 form1;

        private decimal uahToUsd = 0.024m;
        private decimal uahToEur = 0.022m;
        private decimal usdToUah = 41.00m;
        private decimal eurToUah = 45.00m;
        private decimal eurToUsd = 1.10m; 
        private decimal usdToEur = 0.91m;
        private string leftCurrency = "UAH";
        private string rightCurrency = "USD";

        public Form2(Form1 form1)
        {
            this.form1 = form1;

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button2.Click += new EventHandler(button2_Click); // UAH слева                     
            button4.Click += new EventHandler(button4_Click); // EUR слева
            button6.Click += new EventHandler(button6_Click); // USD слева
            button3.Click += new EventHandler(button3_Click); // UAH справа
            button5.Click += new EventHandler(button5_Click); // EUR справа
            button7.Click += new EventHandler(button7_Click); // USD справа

        }

        private void button2_Click(object sender, EventArgs e) => AppendValue1("UAH");
        private void button4_Click(object sender, EventArgs e) => AppendValue1("EUR");
        private void button6_Click(object sender, EventArgs e) => AppendValue1("USD");

        private void button3_Click(object sender, EventArgs e) => AppendValue2("UAH");
        private void button5_Click(object sender, EventArgs e) => AppendValue2("EUR");
        private void button7_Click(object sender, EventArgs e) => AppendValue2("USD");

        // Currency selection on the left
        private void AppendValue1(string Value)
        {
            textBox11.Clear();
            leftCurrency = Value;
            textBox11.TextBoxText += Value;
            UpdateConversion();
        }

        // Currency selection on the right
        private void AppendValue2(string Value)
        {
            textBox13.Clear();
            rightCurrency = Value;
            textBox13.TextBoxText += Value;
            UpdateConversion();
        }

        private decimal ConvertCurrency(decimal amount, string fromCurrency, string toCurrency)
        {
            if (fromCurrency == "UAH" && toCurrency == "USD")
                return amount * uahToUsd;
            if (fromCurrency == "UAH" && toCurrency == "EUR")
                return amount * uahToEur;
            if (fromCurrency == "USD" && toCurrency == "UAH")
                return amount * usdToUah;
            if (fromCurrency == "EUR" && toCurrency == "UAH")
                return amount * eurToUah;
            if (fromCurrency == "EUR" && toCurrency == "USD")
                return amount * eurToUsd;
            if (fromCurrency == "USD" && toCurrency == "EUR")
                return amount * usdToEur;
            if (fromCurrency == toCurrency)
                return amount;

            return 0;
        }

        private void UpdateConversionFromLeft()
        {
            if (decimal.TryParse(textBox11.TextBoxText, out decimal leftValue))
            {
                textBox13.TextBoxText = ConvertCurrency(leftValue, leftCurrency, rightCurrency).ToString("F2");
            }
        }

        private void UpdateConversionFromRight()
        {
            if (decimal.TryParse(textBox13.TextBoxText, out decimal rightValue))
            {
                textBox11.TextBoxText = ConvertCurrency(rightValue, rightCurrency, leftCurrency).ToString("F2");
            }
        }

        private void UpdateConversion()
        {
            if (decimal.TryParse(textBox21.TextBoxText, out decimal inputAmount))
            {
                textBox22.TextBoxText = ConvertCurrency(inputAmount, leftCurrency, rightCurrency).ToString("F2");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this.form1, this); 
            form3.Show();
            this.Hide();
        }

        private void buttonRed2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ввод доступен только для первого поля (слева от знака равенства), " +
                "Так-же необходимо выбрать из какой валюты в какую конвертировать" +
                " нажав на соответствующие кнопки." +
                " Нажав лкм по полю - скопируется содержимое");
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}

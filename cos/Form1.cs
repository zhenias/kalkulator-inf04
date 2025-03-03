using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace cos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            // jeœli 0 - czyœci i dodaje now¹ liczbê (któr¹ wciœniêto!).
            if (textBox1.Text == "0")
            {
                textBox1.Text = string.Empty;
            }

            // jeœli jest jakiœ btn to dodaæ do funkcji zmianaliczby().
            if (button != null)
            {
                zmianaliczby(button.Text);
            }
        }

        /**
         * Button - clear in - textBox1.
         */
        private void czyscBtn(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void wynik_wyczaruj(object sender, EventArgs e)
        {
            string input = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("SprawdŸ wyra¿enie.");
                return;
            }

            double result = 0;
            string[] numbers;
            char operatorUsed = ' ';

            if (input.Contains("+"))
            {
                operatorUsed = '+';
                numbers = input.Split('+');
            }
            else if (input.Contains("-"))
            {
                operatorUsed = '-';
                numbers = input.Split('-');
            }
            else if (input.Contains("*"))
            {
                operatorUsed = '*';
                numbers = input.Split('*');
            }
            else if (input.Contains("/"))
            {
                operatorUsed = '/';
                numbers = input.Split('/');
            }
            else
            {
                MessageBox.Show("Nie poprawny format operatora.", "Popraw b³êdy.");
                return;
            }

            bool firstNumberParsed = double.TryParse(numbers[0], NumberStyles.Any, CultureInfo.InvariantCulture, out double firstNumber);
            if (!firstNumberParsed)
            {
                MessageBox.Show("B³¹d: Niepoprawny format pierwszej liczby.", "B³¹d.");
                return;
            }

            result = firstNumber;

            for (int i = 1; i < numbers.Length; i++)
            {
                bool currentNumberParsed = double.TryParse(numbers[i], NumberStyles.Any, CultureInfo.InvariantCulture, out double currentNumber);
                if (!currentNumberParsed)
                {
                    MessageBox.Show("B³¹d: Niepoprawny format liczby.", "B³¹d.");
                    return;
                }

                switch (operatorUsed)
                {
                    case '+':
                        result += currentNumber;
                        break;
                    case '-':
                        result -= currentNumber;
                        break;
                    case '*':
                        result *= currentNumber;
                        break;
                    case '/':
                        if (currentNumber == 0)
                        {
                            MessageBox.Show("B³¹d: Dzielenie przez 0.", "B³¹d - nie dzieli siê przez zero!");
                            return;
                        }
                        result /= currentNumber;
                        break;
                }
            }

            textBox1.Text = result.ToString();
        }
    }
}

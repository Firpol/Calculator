namespace Калькулятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void N1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void N2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void N3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void N4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void N5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }

        }

        private void N6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }

        }

        private void N7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }

        }

        private void N8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }

        }

        private void N9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }

        }

        private void N0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }

        }

        double FirstValue;
        string? arithmetic;

        private void Add_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            arithmetic = "+";
        }
        private void Sub_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            arithmetic = "-";
        }
        private void Div_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            arithmetic = "/";
        }
        private void Mult_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            arithmetic = "*";
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }


        private void Equal_Click(object sender, EventArgs e)
        {

            double SecondValue;
            double outcome;


            SecondValue = Convert.ToDouble(textBox1.Text);

            if (arithmetic == "+")
            {
                outcome = (FirstValue + SecondValue);
                textBox1.Text = Convert.ToString(outcome);
                FirstValue = outcome;
            }
            if (arithmetic == "-")
            {
                outcome = (FirstValue - SecondValue);
                textBox1.Text = Convert.ToString(outcome);
                FirstValue = outcome;
            }
            if (arithmetic == "*")
            {
                outcome = (FirstValue * SecondValue);
                textBox1.Text = Convert.ToString(outcome);
                FirstValue = outcome;
            }
            if (arithmetic == "/")
            {
                if (SecondValue == 0)
                {
                    textBox1.Text = "НЕ ДОПУСТИМАЯ ОПЕРАЦИЯ";
                }
                else
                {
                    outcome = FirstValue / SecondValue;
                    textBox1.Text = Convert.ToString(outcome);
                    FirstValue = outcome;
                }
            }

        }

    }
}

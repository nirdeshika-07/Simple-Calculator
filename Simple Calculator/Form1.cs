namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        double value1, value2, result = 0;
        String sign;
        public Form1()
        {
            InitializeComponent();
        }
        private void Zero_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "0";
        }

        private void One_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "1";
        }

        private void Two_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "2";
        }

        private void Three_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "3";
        }

        private void Four_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "4";
        }

        private void Five_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "5";
        }

        private void Six_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "6";
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "7";
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "8";
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "9";
        }

        private void Start_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            label1.Text = "";
            label2.Text = "";
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length>0)
            {
                textBox.Text=textBox.Text.Remove(textBox.Text.Length-1,1);
            }
        }


        private void Dot_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.Contains("."))
            {
                textBox.Text = textBox.Text + ".";
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToDouble(textBox.Text);
            sign = "/";
            label1.Text = textBox.Text + sign;
            textBox.Text = "";
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToDouble(textBox.Text);
            sign = "*";
            label1.Text = textBox.Text + sign;
            textBox.Text = "";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToDouble(textBox.Text);
            sign = "+";
            label1.Text = textBox.Text + sign;
            textBox.Text = "";
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToDouble(textBox.Text);
            sign = "-";
            label1.Text = textBox.Text + sign;
            textBox.Text = "";
        }

        private void Percent_Click(object sender, EventArgs e)
        {

        }

        private void Equal_Click(object sender, EventArgs e)
        {
            value2 = Convert.ToDouble(textBox.Text);
            label2.Text = textBox.Text;
            if (sign == "+")
            {
                result = value1 + value2;
                textBox.Text = Convert.ToString(result);
            }
            else if (sign == "-")
            {
                result = value1 - value2;
                textBox.Text = Convert.ToString(result);
            }
            else if (sign == "/")
            {
                result = value1 / value2;
                textBox.Text = Convert.ToString(result);
            }
            else if (sign == "*")
            {
                result = value1 * value2;
                textBox.Text = Convert.ToString(result);
            }
            else if (sign == "%")
            {
                result = value1 * value2;
                textBox.Text = Convert.ToString(result);
            }


        }
    }
}

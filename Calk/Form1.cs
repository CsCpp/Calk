namespace Calk
{
    public partial class Калькулятор : Form
    {
        public Калькулятор()
        {
            InitializeComponent();
        }

        public double a;
        public double b;
        public char c;
        public bool _error0=false;
        public bool _comma = false;
        private void button1_Click(object sender, EventArgs e)
        {
           if(textBox1.Text!="0") textBox1.Text += "1";
           else textBox1.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") textBox1.Text += "2";
            else textBox1.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") textBox1.Text += "3";
            else textBox1.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") textBox1.Text += "4";
            else textBox1.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") textBox1.Text += "5";
            else textBox1.Text = "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") textBox1.Text += "6";
            else textBox1.Text = "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") textBox1.Text += "7";
            else textBox1.Text = "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") textBox1.Text += "8";
            else textBox1.Text = "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") textBox1.Text += "9";
            else textBox1.Text = "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") textBox1.Text += "0";
         
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="0" && textBox1.Text != "") textBox1.Text += "00";
        }

       
        private void button14_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = '+';
            _comma = false;
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = '-';
            _comma = false;
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = '*';
            _comma = false;
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = '/';
            _comma = false;
            textBox1.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            _comma = false;
            textBox1.Text = "";
            switch (c)
            {
                case '+': textBox1.Text = Convert.ToString(a + b); break;
                case '-': textBox1.Text = Convert.ToString(a - b); break;
                case '*': textBox1.Text = Convert.ToString(a * b); break;
                case '/':
                    if (b != 0) { textBox1.Text = Convert.ToString(a / b); }
                    else 
                    { 
                        textBox1.Text = "На ноль делить нельзя!     ";
                        _error0=true;
                    }
                    break;

                default:
                    textBox1.Text = "Error"; break;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (!_comma)
            {
                if (textBox1.Text != "") textBox1.Text += ",";
                else textBox1.Text = "0,";
                _comma = true;
            }
           
        }
       
        private void button18_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(Math.Sqrt(a));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            a = 0; b = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            try
            {
                s = s.Substring(0, s.Length - 1);
            }
            catch (Exception)
            {


            }

            textBox1.Text = s;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Калькулятор от Ивана", "О программе");
        }
    }
}

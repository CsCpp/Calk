namespace Calk
{
    public partial class ����������� : Form
    {
        public �����������()
        {
            InitializeComponent();
        }

        public double a;
        public double b;
        public char c;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "00";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = '+';
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = '-';
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = '*';
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = '/';
            textBox1.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);

            textBox1.Text = "";
            switch (c)
            {
                case '+': textBox1.Text = Convert.ToString(a + b); break;
                case '-': textBox1.Text = Convert.ToString(a - b); break;
                case '*': textBox1.Text = Convert.ToString(a * b); break;
                case '/':
                    if (b != 0) { textBox1.Text = Convert.ToString(a / b); }
                    else textBox1.Text = "�� ���� ������ ������!     ";
                    break;

                default:
                    textBox1.Text = "Error"; break;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
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

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("����������� �� �����", "� ���������");
        }
    }
}

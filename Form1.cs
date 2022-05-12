namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double n1, n2, mult;
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);
            mult = n1 * n2;
            label1.Text = ("O produto  é  " + mult);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double n1, n2, div;
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);
            div = n1 / n2;
            label1.Text = ("O quociente é  " + div);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, soma;
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);
            soma = n1 + n2;
            label1.Text = ("A soma é  " + soma);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n1, n2, sub;
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);
            sub = n1 - n2;
            label1.Text = ("A diferença  é  " + sub);
        }

        
    }
}
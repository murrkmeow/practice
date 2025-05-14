using System.Security.Cryptography.Xml;

namespace task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double x) ||
                !double.TryParse(textBox2.Text, out double xk) ||
                !double.TryParse(textBox3.Text, out double dk) ||
                !double.TryParse(textBox4.Text, out double a))
            {
                MessageBox.Show("Ошибка: Введите корректные значения!");
                return;
            }

            double i = 0;

            while (i < 10)
            {
                double y = Math.Pow(x, 2) + Math.Tan(5 * x + a / x);

                textBox5.Text += Environment.NewLine + 
                    $"x = {x}, y = {y}";

                x += dk;
                i++;
            }
        }
    }
}

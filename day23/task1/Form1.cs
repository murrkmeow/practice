using System;
using System.Windows.Forms;

namespace task1
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
                !double.TryParse(textBox2.Text, out double y) ||
                !double.TryParse(textBox3.Text, out double z))
            {
                MessageBox.Show("Ошибка: Введите корректные числовые значения!");
                return;
            }

            if (z < -1 || z > 1)
            {
                MessageBox.Show("Ошибка: z должно быть в диапазоне от -1 до 1");
                return;
            }

            double beta = Math.Sqrt(10 * Math.Pow(x + Math.Pow(x, y + 2), 1.0 / 3)
                * (Math.Pow(Math.Asin(z), 2) - Math.Abs(x - y)));
            
            textBox4.Text += Environment.NewLine +
                "X = " + x.ToString();
            textBox4.Text += Environment.NewLine +
                "Y = " + y.ToString();
            textBox4.Text += Environment.NewLine + 
                "Z = " + z.ToString();
            textBox4.Text += Environment.NewLine +
                "Beta = " + beta.ToString();
        }
    }
}

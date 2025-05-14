namespace task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double x) ||
                !double.TryParse(textBox2.Text, out double b))
            {
                MessageBox.Show("Ошибка: Введите корректные числовые значения!");
                return;
            }

            double currFunc = 0;

            if (radioButton1.Checked)
            {
                currFunc = Func1(x);
            }
            else if (radioButton2.Checked)
            {
                currFunc = Func2(x);
            }
            else if (radioButton3.Checked)
            {
                currFunc = Func3(x);
            }
            else
            {
                MessageBox.Show("Ошибка: Выберите одну функцию!");
            }

            double xb = x * b;
            double g;

            if (xb < 10 || xb > 0.5)
            {
                g = Math.Pow(Math.E, currFunc - Math.Abs(b));
            }
            else if (xb > 0.1 || xb < 0.5)
            {
                g = Math.Pow(Math.Abs(currFunc + b), 0.5);
            }
            else
            {
                g = 2 * Math.Pow(currFunc, 2);
            }

            textBox4.Text += Environment.NewLine +
                "X = " + x.ToString();
            textBox4.Text += Environment.NewLine +
                "B = " + b.ToString();
            textBox4.Text += Environment.NewLine +
                "G = " + g.ToString();
        }

        public static double Func1(double x)
        {
            return Math.Sinh(x);
        }

        public static double Func2(double x)
        {
            return Math.Pow(x, 2);
        }

        public static double Func3(double x)
        {
            return Math.Pow(Math.E, x);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            //textBox4.Text = Environment.NewLine +
            //    "Окно вывода очищено.";
        }
    }
}

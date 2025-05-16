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
            // Проверяем, выбрана ли строка
            if (listBox1.SelectedIndex == -1)
            {
                label1.Text = "Ошибка: выберите строку из списка!";
                return; // Прерываем выполнение
            }

            // Получаем выбранную строку
            string str = listBox1.SelectedItem.ToString();
            int count = 0;

            // Подсчет строчных русских букв
            foreach (char c in str)
            {
                if ((c >= 'а' && c <= 'я') || c == 'ё')
                {
                    count++;
                }
            }

            label1.Text = $"Количество строчных русских букв = {count}";
        }
    }
}

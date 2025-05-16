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
            // ���������, ������� �� ������
            if (listBox1.SelectedIndex == -1)
            {
                label1.Text = "������: �������� ������ �� ������!";
                return; // ��������� ����������
            }

            // �������� ��������� ������
            string str = listBox1.SelectedItem.ToString();
            int count = 0;

            // ������� �������� ������� ����
            foreach (char c in str)
            {
                if ((c >= '�' && c <= '�') || c == '�')
                {
                    count++;
                }
            }

            label1.Text = $"���������� �������� ������� ���� = {count}";
        }
    }
}

namespace task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            name.Text = "";
            surname.Text = "";
            secname.Text = "";
            rbuttman.Checked = false;
            rbuttwoman.Checked = false;
            //dateTimePicker1.Checked = false;
            rbuttexp1.Checked = false;
            rbuttexp2.Checked = false;
            rbuttexp3.Checked = false;
            rbuttexp4.Checked = false;
            rbuttexp5.Checked = false;
            rbuttfull.Checked = false;
            rbuttonhome.Checked = false;
            rbuttnofull.Checked = false;
            rbuttper.Checked = false;
            bonusDown.Value = 0;
            bonusUp.Value = 0;
            cboxdriver.Checked = false;
            cboxauto.Checked = false;
            cboxA.Checked = false;
            cboxB.Checked = false;
            cboxC.Checked = false;
            cboxD.Checked = false;
            res.Text = "";
            email.Text = "";
            mobnumber.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ���� ������
            string resumeText = "";
            resumeText += $"�������: {surname.Text}\r\n";
            resumeText += $"���: {name.Text}\r\n";
            resumeText += $"��������: {secname.Text}\r\n";
            resumeText += $"���: {(rbuttman.Checked ? "�������" : rbuttwoman.Checked ? "�������" : "�� ������")}\r\n";
            resumeText += $"���� ��������: {dateTimePicker1.Value.ToShortDateString()}\r\n";
            resumeText += $"����� ����������: {space.Text}\r\n";
            resumeText += $"����������� �����: {email.Text}\r\n";
            resumeText += $"��������� �������: {mob.Text} {mobnumber.Text}\r\n";

            resumeText += "���� ������: ";
            if (rbuttexp1.Checked) resumeText += "��� ����� ������";
            else if (rbuttexp2.Checked) resumeText += "�� 1 ����";
            else if (rbuttexp3.Checked) resumeText += "�� 1 ���� �� 5 ���";
            else if (rbuttexp4.Checked) resumeText += "�� 5 �� 9 ���";
            else if (rbuttexp5.Checked) resumeText += "�� 10 ���";
            resumeText += "\r\n";

            resumeText += "�������������� ��������:\r\n";
            if (cboxdriver.Checked) resumeText += "- ������������ �������������\r\n";
            if (cboxauto.Checked) resumeText += "- ������� ������� ����\r\n";

            resumeText += "��������� ����: ";
            if (cboxA.Checked) resumeText += "A ";
            if (cboxB.Checked) resumeText += "B ";
            if (cboxC.Checked) resumeText += "C ";
            if (cboxD.Checked) resumeText += "D ";
            resumeText += "\r\n";

            resumeText += $"�������� ��������: �� {bonusDown.Value} �� {bonusUp.Value} ���.\r\n";

            resumeText += "��� ���������: ";
            if (rbuttfull.Checked) resumeText += "������ ���������";
            else if (rbuttnofull.Checked) resumeText += "��������� ���������";
            else if (rbuttonhome.Checked) resumeText += "������ �� ����";
            else if (rbuttper.Checked) resumeText += "��������� ������";
            resumeText += "\r\n";

            // �������� � ��������� ����
            res.Text = resumeText;

            // ���������� � ����
            string filePath = "������.txt";
            try
            {
                File.WriteAllText(filePath, resumeText);
                MessageBox.Show("������ ������� ��������� � ����: " + filePath, "�����");
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ��� ���������� �����: " + ex.Message, "������");
            }
        }
    }
}

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
            // Сбор данных
            string resumeText = "";
            resumeText += $"Фамилия: {surname.Text}\r\n";
            resumeText += $"Имя: {name.Text}\r\n";
            resumeText += $"Отчество: {secname.Text}\r\n";
            resumeText += $"Пол: {(rbuttman.Checked ? "Мужской" : rbuttwoman.Checked ? "Женский" : "Не указан")}\r\n";
            resumeText += $"Дата рождения: {dateTimePicker1.Value.ToShortDateString()}\r\n";
            resumeText += $"Место проживания: {space.Text}\r\n";
            resumeText += $"Электронная почта: {email.Text}\r\n";
            resumeText += $"Мобильный телефон: {mob.Text} {mobnumber.Text}\r\n";

            resumeText += "Опыт работы: ";
            if (rbuttexp1.Checked) resumeText += "Нет опыта работы";
            else if (rbuttexp2.Checked) resumeText += "До 1 года";
            else if (rbuttexp3.Checked) resumeText += "От 1 года до 5 лет";
            else if (rbuttexp4.Checked) resumeText += "От 5 до 9 лет";
            else if (rbuttexp5.Checked) resumeText += "От 10 лет";
            resumeText += "\r\n";

            resumeText += "Дополнительные сведения:\r\n";
            if (cboxdriver.Checked) resumeText += "- Водительское удостоверение\r\n";
            if (cboxauto.Checked) resumeText += "- Наличие личного авто\r\n";

            resumeText += "Категория прав: ";
            if (cboxA.Checked) resumeText += "A ";
            if (cboxB.Checked) resumeText += "B ";
            if (cboxC.Checked) resumeText += "C ";
            if (cboxD.Checked) resumeText += "D ";
            resumeText += "\r\n";

            resumeText += $"Желаемая зарплата: от {bonusDown.Value} до {bonusUp.Value} руб.\r\n";

            resumeText += "Тип занятости: ";
            if (rbuttfull.Checked) resumeText += "Полная занятость";
            else if (rbuttnofull.Checked) resumeText += "Частичная занятость";
            else if (rbuttonhome.Checked) resumeText += "Работа на дому";
            else if (rbuttper.Checked) resumeText += "Посменная работа";
            resumeText += "\r\n";

            // Показать в текстовом поле
            res.Text = resumeText;

            // Сохранение в файл
            string filePath = "Резюме.txt";
            try
            {
                File.WriteAllText(filePath, resumeText);
                MessageBox.Show("Резюме успешно сохранено в файл: " + filePath, "Успех");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла: " + ex.Message, "Ошибка");
            }
        }
    }
}

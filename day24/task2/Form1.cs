using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void InitializeChart()
        {
            // ��������� ������� �������
            chart1.ChartAreas.Add(new ChartArea("MainArea"));

            // ��������� ����
            chart1.ChartAreas[0].AxisX.Title = "X";
            chart1.ChartAreas[0].AxisY.Title = "Y";
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;

            // ���������� ����� ��� �������
            chart1.Series.Add(new Series("sin(x)"));
            chart1.Series["sin(x)"].ChartType = SeriesChartType.Line;
            chart1.Series["sin(x)"].Color = System.Drawing.Color.Blue;
            chart1.Series["sin(x)"].BorderWidth = 2;

            chart1.Series.Add(new Series("cos(x)"));
            chart1.Series["cos(x)"].ChartType = SeriesChartType.Line;
            chart1.Series["cos(x)"].Color = System.Drawing.Color.Red;
            chart1.Series["cos(x)"].BorderWidth = 2;

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            try
            {
                // ��������� � ����� ��������� ��������
                double Xmin = double.Parse(textBoxXmin.Text);
                double Xmax = double.Parse(textBoxXmax.Text);
                double Step = double.Parse(textBoxStep.Text);

                // �������� ������������ ��������� ������
                if (Xmin >= Xmax)
                {
                    MessageBox.Show("Xmin ������ ���� ������ Xmax", "������",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Step <= 0)
                {
                    MessageBox.Show("��� ������ ���� ������������� ������", "������",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ���������� ����� �������
                int count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;

                // ������ �������� X - ����� ��� ����� ��������
                double[] x = new double[count];

                // ��� ������� Y - �� ������ ��� ������� �������
                double[] y1 = new double[count]; // sin(x)
                double[] y2 = new double[count]; // cos(x)

                // ������������ ����� ��� �������� �������
                for (int i = 0; i < count; i++)
                {
                    // ��������� �������� X
                    x[i] = Xmin + Step * i;

                    // ��������� �������� ������� � ����� X
                    y1[i] = Math.Sin(x[i]);
                    y2[i] = Math.Cos(x[i]);
                }

                // ����������� ��� �������
                chart1.ChartAreas[0].AxisX.Minimum = Xmin;
                chart1.ChartAreas[0].AxisX.Maximum = Xmax;

                // ���������� ��� �����
                chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;

                // ������� ���������� ������
                chart1.Series["sin(x)"].Points.Clear();
                chart1.Series["cos(x)"].Points.Clear();

                // ��������� ����������� �������� � �������
                chart1.Series["sin(x)"].Points.DataBindXY(x, y1);
                chart1.Series["cos(x)"].Points.DataBindXY(x, y2);
            }
            catch (FormatException)
            {
                MessageBox.Show("����������, ������� ���������� �������� ��������", "������",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"��������� ������: {ex.Message}", "������",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

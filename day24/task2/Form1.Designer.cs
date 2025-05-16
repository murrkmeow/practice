namespace task2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxXmin = new TextBox();
            textBoxXmax = new TextBox();
            textBoxStep = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(12, 12);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(454, 741);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // textBoxXmin
            // 
            textBoxXmin.Location = new Point(13, 436);
            textBoxXmin.Name = "textBoxXmin";
            textBoxXmin.Size = new Size(110, 25);
            textBoxXmin.TabIndex = 1;
            // 
            // textBoxXmax
            // 
            textBoxXmax.Location = new Point(129, 436);
            textBoxXmax.Name = "textBoxXmax";
            textBoxXmax.Size = new Size(110, 25);
            textBoxXmax.TabIndex = 1;
            // 
            // textBoxStep
            // 
            textBoxStep.Location = new Point(245, 436);
            textBoxStep.Name = "textBoxStep";
            textBoxStep.Size = new Size(110, 25);
            textBoxStep.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 416);
            label1.Name = "label1";
            label1.Size = new Size(37, 17);
            label1.TabIndex = 2;
            label1.Text = "Xmin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 416);
            label2.Name = "label2";
            label2.Size = new Size(40, 17);
            label2.TabIndex = 2;
            label2.Text = "Xmax";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(245, 416);
            label3.Name = "label3";
            label3.Size = new Size(34, 17);
            label3.TabIndex = 2;
            label3.Text = "Step";
            // 
            // button1
            // 
            button1.Location = new Point(383, 436);
            button1.Name = "button1";
            button1.Size = new Size(83, 25);
            button1.TabIndex = 3;
            button1.Text = "Culculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonCalc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 473);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxStep);
            Controls.Add(textBoxXmax);
            Controls.Add(textBoxXmin);
            Controls.Add(chart1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TextBox textBoxXmin;
        private TextBox textBoxXmax;
        private TextBox textBoxStep;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}

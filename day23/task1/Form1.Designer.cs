namespace task1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(42, 32);
            label1.Name = "label1";
            label1.Size = new Size(177, 29);
            label1.TabIndex = 0;
            label1.Text = "Введите значение X:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(42, 74);
            label2.Name = "label2";
            label2.Size = new Size(177, 29);
            label2.TabIndex = 1;
            label2.Text = "Введите значение Y:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(42, 119);
            label3.Name = "label3";
            label3.Size = new Size(177, 29);
            label3.TabIndex = 2;
            label3.Text = "Введите значение Z:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(42, 169);
            label4.Name = "label4";
            label4.Size = new Size(304, 29);
            label4.TabIndex = 3;
            label4.Text = "Результат выполнения программы:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(238, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 25);
            textBox1.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12.8301888F);
            textBox4.Location = new Point(42, 201);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ScrollBars = ScrollBars.Vertical;
            textBox4.Size = new Size(724, 237);
            textBox4.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(238, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(299, 25);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(238, 119);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(299, 25);
            textBox3.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(613, 62);
            button1.Name = "button1";
            button1.Size = new Size(136, 52);
            button1.TabIndex = 5;
            button1.Text = "Выполнить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
    }
}

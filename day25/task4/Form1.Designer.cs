﻿namespace WinFormsApp4
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
            helpProvider1 = new HelpProvider();
            txba = new TextBox();
            txBb = new TextBox();
            btnWork = new Button();
            btnRun = new Button();
            btnHelp = new Button();
            SuspendLayout();
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "C:\\Users\\murrkmeow\\Downloads\\Telegram Desktop\\Шулейко_day24\\day24\\WinFormsApp4\\bin\\Debug\\net8.0-windows\\Help.txt";
            // 
            // txba
            // 
            helpProvider1.SetHelpString(txba, "For input integer A");
            txba.Location = new Point(46, 48);
            txba.Name = "txba";
            helpProvider1.SetShowHelp(txba, true);
            txba.Size = new Size(110, 25);
            txba.TabIndex = 0;
            txba.TextChanged += txba_TextChanged;
            // 
            // txBb
            // 
            helpProvider1.SetHelpString(txBb, "For input integer B");
            txBb.Location = new Point(46, 98);
            txBb.Name = "txBb";
            helpProvider1.SetShowHelp(txBb, true);
            txBb.Size = new Size(110, 25);
            txBb.TabIndex = 1;
            // 
            // btnWork
            // 
            helpProvider1.SetHelpString(btnWork, "Start work");
            btnWork.Location = new Point(222, 48);
            btnWork.Name = "btnWork";
            helpProvider1.SetShowHelp(btnWork, true);
            btnWork.Size = new Size(82, 25);
            btnWork.TabIndex = 2;
            btnWork.Text = "work";
            btnWork.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            helpProvider1.SetHelpString(btnRun, "Run");
            btnRun.Location = new Point(222, 98);
            btnRun.Name = "btnRun";
            helpProvider1.SetShowHelp(btnRun, true);
            btnRun.Size = new Size(82, 25);
            btnRun.TabIndex = 3;
            btnRun.Text = "run";
            btnRun.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            btnHelp.Location = new Point(365, 48);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(82, 25);
            btnHelp.TabIndex = 4;
            btnHelp.Text = "help";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 183);
            Controls.Add(btnHelp);
            Controls.Add(btnRun);
            Controls.Add(btnWork);
            Controls.Add(txBb);
            Controls.Add(txba);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            HelpButton = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private HelpProvider helpProvider1;
        private TextBox txba;
        private TextBox txBb;
        private Button btnWork;
        private Button btnRun;
        private Button btnHelp;
    }
}

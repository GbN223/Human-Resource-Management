﻿namespace NguyenChiBao_WinApp.Pages.ListPage
{
    partial class frmListCategory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(35, 46);
            button1.Name = "button1";
            button1.Size = new Size(75, 58);
            button1.TabIndex = 0;
            button1.Text = "Bộ phận";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(131, 46);
            button2.Name = "button2";
            button2.Size = new Size(75, 58);
            button2.TabIndex = 1;
            button2.Text = "Trình độ văn hóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(240, 46);
            button3.Name = "button3";
            button3.Size = new Size(75, 58);
            button3.TabIndex = 2;
            button3.Text = "Vị trí công việc";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(363, 46);
            button4.Name = "button4";
            button4.Size = new Size(75, 58);
            button4.TabIndex = 3;
            button4.Text = "Dự án";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(477, 46);
            button5.Name = "button5";
            button5.Size = new Size(75, 58);
            button5.TabIndex = 4;
            button5.Text = "Định vị chấm công";
            button5.UseVisualStyleBackColor = true;
            // 
            // frmListCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmListCategory";
            Text = "frmListCategory";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button3;
        private Button button5;
    }
}
﻿namespace NguyenChiBao_WinApp.Pages.FillPage
{
    partial class frmFillResignationDecision
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            comboBox3 = new ComboBox();
            label7 = new Label();
            textBox2 = new TextBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Size = new Size(1169, 37);
            // 
            // panel3
            // 
            panel3.Location = new Point(969, 0);
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.Red;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Red;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 503);
            panel1.Size = new Size(1169, 44);
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel1);
            panel4.Size = new Size(1169, 466);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.61111F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.3888855F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 634F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 178F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 1, 3);
            tableLayoutPanel1.Controls.Add(label4, 1, 4);
            tableLayoutPanel1.Controls.Add(label5, 1, 5);
            tableLayoutPanel1.Controls.Add(textBox1, 2, 1);
            tableLayoutPanel1.Controls.Add(comboBox1, 2, 2);
            tableLayoutPanel1.Controls.Add(comboBox2, 2, 3);
            tableLayoutPanel1.Controls.Add(dateTimePicker2, 2, 5);
            tableLayoutPanel1.Controls.Add(comboBox3, 2, 4);
            tableLayoutPanel1.Controls.Add(label7, 1, 6);
            tableLayoutPanel1.Controls.Add(textBox2, 2, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.51485F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.48515F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 147F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(1169, 466);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 36);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "1. Mã quyết định";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 74);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "2. Bộ phận";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 116);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "4. Nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(116, 164);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 3;
            label4.Text = "5. Lý do";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(116, 208);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 4;
            label5.Text = "6. Ngày hiệu lực";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(339, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(628, 23);
            textBox1.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(339, 77);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(628, 23);
            comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.Dock = DockStyle.Fill;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(339, 119);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(628, 23);
            comboBox2.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(339, 211);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 9;
            // 
            // comboBox3
            // 
            comboBox3.Dock = DockStyle.Fill;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(339, 167);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(628, 23);
            comboBox3.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(116, 257);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 12;
            label7.Text = "7. Ghi chú";
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(339, 260);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(628, 141);
            textBox2.TabIndex = 13;
            // 
            // frmFillResignationDecision
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 547);
            Name = "frmFillResignationDecision";
            Text = "frmFillResignationDecision";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox3;
        private Label label7;
        private TextBox textBox2;
    }
}
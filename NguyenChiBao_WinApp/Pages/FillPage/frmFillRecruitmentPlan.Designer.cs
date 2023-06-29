using System.Windows.Forms;

namespace NguyenChiBao_WinApp.Pages.FillPage
{
    partial class frmFillRecruitmentPlan
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
            textBox2 = new TextBox();
            comboBox3 = new ComboBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label6 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label7 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label8 = new Label();
            tbxCode = new TextBox();
            label10 = new Label();
            cbxRequire = new ComboBox();
            label11 = new Label();
            tbxWorkplace = new TextBox();
            label9 = new Label();
            lblQuanity = new Label();
            label13 = new Label();
            lblAgeFrom = new Label();
            label12 = new Label();
            lblAgeTo = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
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
            panel1.Location = new Point(0, 505);
            panel1.Padding = new Padding(110, 0, 0, 0);
            panel1.Size = new Size(1169, 42);
            // 
            // btnSaveBack
            // 
            btnSaveBack.Location = new Point(230, 0);
            btnSaveBack.Size = new Size(111, 42);
            // 
            // btnSave
            // 
            btnSave.Location = new Point(110, 0);
            btnSave.Size = new Size(120, 42);
            // 
            // panel4
            // 
            panel4.Location = new Point(0, 0);
            panel4.Size = new Size(1169, 547);
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Top;
            textBox2.Location = new Point(229, 93);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(937, 29);
            textBox2.TabIndex = 8;
            // 
            // comboBox3
            // 
            comboBox3.Dock = DockStyle.Top;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(229, 163);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(937, 23);
            comboBox3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(113, 160);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 6;
            label4.Text = "Trình độ văn hóa";
            // 
            // comboBox2
            // 
            comboBox2.Dock = DockStyle.Top;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(229, 128);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(937, 23);
            comboBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(113, 125);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 4;
            label3.Text = "Vị trí công việc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(113, 90);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 2;
            label2.Text = "Nơi làm việc";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(229, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(937, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(113, 55);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã kế hoạch";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 116F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 358F));
            tableLayoutPanel1.Controls.Add(label1, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox1, 2, 2);
            tableLayoutPanel1.Controls.Add(label2, 1, 3);
            tableLayoutPanel1.Controls.Add(label3, 1, 4);
            tableLayoutPanel1.Controls.Add(comboBox2, 2, 4);
            tableLayoutPanel1.Controls.Add(label4, 1, 5);
            tableLayoutPanel1.Controls.Add(comboBox3, 2, 5);
            tableLayoutPanel1.Controls.Add(textBox2, 2, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(1169, 547);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 116F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 358F));
            tableLayoutPanel2.Controls.Add(label5, 1, 2);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(113, 40);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 0;
            label5.Text = "Mã kế hoạch";
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Top;
            textBox3.Location = new Point(229, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(352, 23);
            textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Dock = DockStyle.Top;
            textBox4.Location = new Point(229, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(352, 23);
            textBox4.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 116F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 358F));
            tableLayoutPanel3.Controls.Add(label6, 1, 2);
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Location = new Point(113, 0);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 0;
            label6.Text = "Mã yêu cầu";
            // 
            // textBox5
            // 
            textBox5.Dock = DockStyle.Top;
            textBox5.Location = new Point(229, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(352, 23);
            textBox5.TabIndex = 1;
            // 
            // textBox6
            // 
            textBox6.Dock = DockStyle.Top;
            textBox6.Location = new Point(229, 3);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(352, 23);
            textBox6.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Top;
            label7.Location = new Point(113, 0);
            label7.Name = "label7";
            label7.Size = new Size(110, 15);
            label7.TabIndex = 0;
            label7.Text = "Mã yêu cầu";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 116F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 358F));
            tableLayoutPanel4.Controls.Add(label7, 1, 2);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 352F));
            tableLayoutPanel5.Controls.Add(label8, 1, 2);
            tableLayoutPanel5.Controls.Add(tbxCode, 2, 2);
            tableLayoutPanel5.Controls.Add(label10, 1, 4);
            tableLayoutPanel5.Controls.Add(cbxRequire, 2, 4);
            tableLayoutPanel5.Controls.Add(label11, 1, 5);
            tableLayoutPanel5.Controls.Add(tbxWorkplace, 2, 5);
            tableLayoutPanel5.Controls.Add(label9, 1, 6);
            tableLayoutPanel5.Controls.Add(lblQuanity, 2, 6);
            tableLayoutPanel5.Controls.Add(label13, 1, 7);
            tableLayoutPanel5.Controls.Add(lblAgeFrom, 2, 7);
            tableLayoutPanel5.Controls.Add(label12, 1, 8);
            tableLayoutPanel5.Controls.Add(lblAgeTo, 2, 8);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 37);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 10;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 9F));
            tableLayoutPanel5.Size = new Size(1169, 468);
            tableLayoutPanel5.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Top;
            label8.Location = new Point(113, 55);
            label8.Name = "label8";
            label8.Size = new Size(116, 15);
            label8.TabIndex = 0;
            label8.Text = "Mã kế hoạch";
            // 
            // tbxCode
            // 
            tbxCode.Dock = DockStyle.Top;
            tbxCode.Location = new Point(235, 58);
            tbxCode.Name = "tbxCode";
            tbxCode.Size = new Size(931, 23);
            tbxCode.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Top;
            label10.Location = new Point(113, 105);
            label10.Name = "label10";
            label10.Size = new Size(116, 15);
            label10.TabIndex = 4;
            label10.Text = "Yêu cầu";
            // 
            // cbxRequire
            // 
            cbxRequire.Dock = DockStyle.Top;
            cbxRequire.FormattingEnabled = true;
            cbxRequire.Location = new Point(235, 108);
            cbxRequire.Name = "cbxRequire";
            cbxRequire.Size = new Size(931, 23);
            cbxRequire.TabIndex = 5;
            cbxRequire.SelectedIndexChanged += cbxRequire_SelectedIndexChanged;
            cbxRequire.SelectedValueChanged += cbxRequire_SelectedValueChanged;
            cbxRequire.Click += comboBox4_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Top;
            label11.Location = new Point(113, 160);
            label11.Name = "label11";
            label11.Size = new Size(116, 15);
            label11.TabIndex = 6;
            label11.Text = "Nơi làm việc";
            // 
            // tbxWorkplace
            // 
            tbxWorkplace.Dock = DockStyle.Top;
            tbxWorkplace.Location = new Point(235, 163);
            tbxWorkplace.Multiline = true;
            tbxWorkplace.Name = "tbxWorkplace";
            tbxWorkplace.Size = new Size(931, 104);
            tbxWorkplace.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(113, 272);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 8;
            label9.Text = "Số lượng";
            // 
            // lblQuanity
            // 
            lblQuanity.AutoSize = true;
            lblQuanity.Location = new Point(235, 272);
            lblQuanity.Name = "lblQuanity";
            lblQuanity.Size = new Size(0, 15);
            lblQuanity.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(113, 332);
            label13.Name = "label13";
            label13.Size = new Size(44, 15);
            label13.TabIndex = 11;
            label13.Text = "Tuổi từ";
            // 
            // lblAgeFrom
            // 
            lblAgeFrom.AutoSize = true;
            lblAgeFrom.Location = new Point(235, 332);
            lblAgeFrom.Name = "lblAgeFrom";
            lblAgeFrom.Size = new Size(0, 15);
            lblAgeFrom.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(113, 362);
            label12.Name = "label12";
            label12.Size = new Size(53, 15);
            label12.TabIndex = 12;
            label12.Text = "Tuổi đến";
            // 
            // lblAgeTo
            // 
            lblAgeTo.AutoSize = true;
            lblAgeTo.Location = new Point(235, 362);
            lblAgeTo.Name = "lblAgeTo";
            lblAgeTo.Size = new Size(0, 15);
            lblAgeTo.TabIndex = 13;
            // 
            // frmFillRecruitmentPlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 547);
            Controls.Add(tableLayoutPanel5);
            Controls.Add(tableLayoutPanel1);
            Name = "frmFillRecruitmentPlan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFillRecruitmentPlan";
            Controls.SetChildIndex(panel4, 0);
            Controls.SetChildIndex(tableLayoutPanel1, 0);
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(tableLayoutPanel5, 0);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayout;
        private TextBox textBox2;
        private ComboBox comboBox3;
        private Label label4;
        private ComboBox comboBox2;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox4;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label6;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label8;
        private TextBox tbxCode;
        private Label label10;
        private ComboBox cbxRequire;
        private Label label11;
        private TextBox tbxWorkplace;
        private Label label9;
        private Label lblQuanity;
        private Label label13;
        private Label lblAgeFrom;
        private Label label12;
        private Label lblAgeTo;
    }
}
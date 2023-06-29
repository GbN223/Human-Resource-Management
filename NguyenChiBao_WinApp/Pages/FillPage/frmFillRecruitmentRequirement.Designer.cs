namespace NguyenChiBao_WinApp.Pages.FillPage
{
    partial class frmFillRecruitmentRequirement
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
            tbxCode = new TextBox();
            label2 = new Label();
            cbxDepartment = new ComboBox();
            label3 = new Label();
            cbxPosition = new ComboBox();
            label4 = new Label();
            cbxEducationLevel = new ComboBox();
            label5 = new Label();
            nUDQuanity = new NumericUpDown();
            label6 = new Label();
            nUDAgeFrom = new NumericUpDown();
            label9 = new Label();
            nUDAgeTo = new NumericUpDown();
            label10 = new Label();
            tbxExperience = new TextBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUDQuanity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDAgeFrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDAgeTo).BeginInit();
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
            panel1.Location = new Point(0, 514);
            panel1.Padding = new Padding(110, 0, 0, 0);
            panel1.Size = new Size(1169, 33);
            // 
            // button3
            // 
       
            // button2
            // 
            btnSaveBack.Location = new Point(230, 0);
            btnSaveBack.Size = new Size(111, 33);
            // 
            // button1
            // 
            btnSave.Location = new Point(110, 0);
            btnSave.Size = new Size(120, 33);
            // 
            // panel4
            // 
            panel4.Location = new Point(0, 0);
            panel4.Size = new Size(1169, 547);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 116F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 358F));
            tableLayoutPanel1.Controls.Add(label1, 1, 2);
            tableLayoutPanel1.Controls.Add(tbxCode, 2, 2);
            tableLayoutPanel1.Controls.Add(label2, 1, 3);
            tableLayoutPanel1.Controls.Add(cbxDepartment, 2, 3);
            tableLayoutPanel1.Controls.Add(label3, 1, 4);
            tableLayoutPanel1.Controls.Add(cbxPosition, 2, 4);
            tableLayoutPanel1.Controls.Add(label4, 1, 5);
            tableLayoutPanel1.Controls.Add(cbxEducationLevel, 2, 5);
            tableLayoutPanel1.Controls.Add(label5, 1, 6);
            tableLayoutPanel1.Controls.Add(nUDQuanity, 2, 6);
            tableLayoutPanel1.Controls.Add(label6, 1, 7);
            tableLayoutPanel1.Controls.Add(nUDAgeFrom, 2, 7);
            tableLayoutPanel1.Controls.Add(label9, 1, 8);
            tableLayoutPanel1.Controls.Add(nUDAgeTo, 2, 8);
            tableLayoutPanel1.Controls.Add(label10, 1, 9);
            tableLayoutPanel1.Controls.Add(tbxExperience, 2, 9);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 37);
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
            tableLayoutPanel1.Size = new Size(1169, 477);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(113, 55);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã yêu cầu";
            // 
            // tbxCode
            // 
            tbxCode.Dock = DockStyle.Top;
            tbxCode.Location = new Point(229, 58);
            tbxCode.Name = "tbxCode";
            tbxCode.Size = new Size(937, 23);
            tbxCode.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(113, 90);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 2;
            label2.Text = "Bộ phận";
            // 
            // cbxDepartment
            // 
            cbxDepartment.Dock = DockStyle.Top;
            cbxDepartment.FormattingEnabled = true;
            cbxDepartment.ItemHeight = 15;
            cbxDepartment.Location = new Point(229, 93);
            cbxDepartment.Name = "cbxDepartment";
            cbxDepartment.Size = new Size(937, 23);
            cbxDepartment.TabIndex = 3;
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
            // cbxPosition
            // 
            cbxPosition.Dock = DockStyle.Top;
            cbxPosition.FormattingEnabled = true;
            cbxPosition.Location = new Point(229, 128);
            cbxPosition.Name = "cbxPosition";
            cbxPosition.Size = new Size(937, 23);
            cbxPosition.TabIndex = 5;
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
            // cbxEducationLevel
            // 
            cbxEducationLevel.Dock = DockStyle.Top;
            cbxEducationLevel.FormattingEnabled = true;
            cbxEducationLevel.Location = new Point(229, 163);
            cbxEducationLevel.Name = "cbxEducationLevel";
            cbxEducationLevel.Size = new Size(937, 23);
            cbxEducationLevel.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(113, 195);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 8;
            label5.Text = "Số lượng";
            // 
            // nUDQuanity
            // 
            nUDQuanity.Location = new Point(229, 198);
            nUDQuanity.Name = "nUDQuanity";
            nUDQuanity.Size = new Size(77, 23);
            nUDQuanity.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Location = new Point(113, 230);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 10;
            label6.Text = "Tuổi từ";
            // 
            // nUDAgeFrom
            // 
            nUDAgeFrom.Location = new Point(229, 233);
            nUDAgeFrom.Name = "nUDAgeFrom";
            nUDAgeFrom.Size = new Size(77, 23);
            nUDAgeFrom.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Top;
            label9.Location = new Point(113, 265);
            label9.Name = "label9";
            label9.Size = new Size(110, 15);
            label9.TabIndex = 14;
            label9.Text = "Tuổi đến";
            // 
            // nUDAgeTo
            // 
            nUDAgeTo.Location = new Point(229, 268);
            nUDAgeTo.Name = "nUDAgeTo";
            nUDAgeTo.Size = new Size(77, 23);
            nUDAgeTo.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Top;
            label10.Location = new Point(113, 300);
            label10.Name = "label10";
            label10.Size = new Size(110, 15);
            label10.TabIndex = 17;
            label10.Text = "Kinh nghiệm";
            // 
            // tbxExperience
            // 
            tbxExperience.Dock = DockStyle.Top;
            tbxExperience.Location = new Point(229, 303);
            tbxExperience.Multiline = true;
            tbxExperience.Name = "tbxExperience";
            tbxExperience.Size = new Size(937, 84);
            tbxExperience.TabIndex = 18;
            // 
            // frmFillRecruitmentRequirement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 547);
            Controls.Add(tableLayoutPanel1);
            Name = "frmFillRecruitmentRequirement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFillRecruitmentRequirement";
            Controls.SetChildIndex(panel4, 0);
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(tableLayoutPanel1, 0);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUDQuanity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDAgeFrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDAgeTo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox tbxCode;
        private Label label2;
        private ComboBox cbxDepartment;
        private Label label3;
        private ComboBox cbxPosition;
        private Label label4;
        private ComboBox cbxEducationLevel;
        private Label label5;
        private NumericUpDown nUDQuanity;
        private Label label6;
        private NumericUpDown nUDAgeFrom;
        private Label label9;
        private NumericUpDown nUDAgeTo;
        private Label label10;
        private TextBox tbxExperience;
    }
}
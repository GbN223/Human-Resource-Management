namespace NguyenChiBao_WinApp.Pages.FillPage
{
    partial class frmFillCandidateProfile
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
            lblAgeTo = new Label();
            label12 = new Label();
            lblAgeFrom = new Label();
            label13 = new Label();
            lblQuanity = new Label();
            label9 = new Label();
            label11 = new Label();
            label10 = new Label();
            tbxCode = new TextBox();
            label8 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            tbxFullName = new TextBox();
            cbxGender = new ComboBox();
            tbxAddress = new TextBox();
            tbxEmail = new TextBox();
            label1 = new Label();
            panel5 = new Panel();
            mcBirthDate = new MonthCalendar();
            cbxBirthDate = new ComboBox();
            tbxPhone = new TextBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel5.SuspendLayout();
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
            panel1.Location = new Point(0, 513);
            panel1.Size = new Size(1169, 34);
            // 
            // btnSaveBack
            // 
            btnSaveBack.Size = new Size(111, 34);
            // 
            // btnSave
            // 
            btnSave.Size = new Size(120, 34);
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel5);
            panel4.Size = new Size(1169, 476);
            // 
            // lblAgeTo
            // 
            lblAgeTo.AutoSize = true;
            lblAgeTo.Location = new Point(3, 0);
            lblAgeTo.Name = "lblAgeTo";
            lblAgeTo.Size = new Size(0, 15);
            lblAgeTo.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(113, 282);
            label12.Name = "label12";
            label12.Size = new Size(36, 15);
            label12.TabIndex = 12;
            label12.Text = "Email";
            // 
            // lblAgeFrom
            // 
            lblAgeFrom.AutoSize = true;
            lblAgeFrom.Location = new Point(3, 282);
            lblAgeFrom.Name = "lblAgeFrom";
            lblAgeFrom.Size = new Size(0, 15);
            lblAgeFrom.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(113, 206);
            label13.Name = "label13";
            label13.Size = new Size(43, 15);
            label13.TabIndex = 11;
            label13.Text = "Địa chỉ";
            // 
            // lblQuanity
            // 
            lblQuanity.AutoSize = true;
            lblQuanity.Location = new Point(3, 325);
            lblQuanity.Name = "lblQuanity";
            lblQuanity.Size = new Size(0, 15);
            lblQuanity.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(113, 165);
            label9.Name = "label9";
            label9.Size = new Size(76, 15);
            label9.TabIndex = 8;
            label9.Text = "Số điện thoại";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Top;
            label11.Location = new Point(113, 123);
            label11.Name = "label11";
            label11.Size = new Size(116, 15);
            label11.TabIndex = 6;
            label11.Text = "Giới tính";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Top;
            label10.Location = new Point(113, 84);
            label10.Name = "label10";
            label10.Size = new Size(116, 15);
            label10.TabIndex = 4;
            label10.Text = "Họ và tên";
            // 
            // tbxCode
            // 
            tbxCode.Dock = DockStyle.Top;
            tbxCode.Location = new Point(235, 42);
            tbxCode.Name = "tbxCode";
            tbxCode.Size = new Size(931, 23);
            tbxCode.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Top;
            label8.Location = new Point(113, 39);
            label8.Name = "label8";
            label8.Size = new Size(116, 15);
            label8.TabIndex = 0;
            label8.Text = "Mã ứng viên";
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
            tableLayoutPanel5.Controls.Add(label11, 1, 5);
            tableLayoutPanel5.Controls.Add(label9, 1, 6);
            tableLayoutPanel5.Controls.Add(label13, 1, 7);
            tableLayoutPanel5.Controls.Add(label12, 1, 8);
            tableLayoutPanel5.Controls.Add(lblQuanity, 0, 9);
            tableLayoutPanel5.Controls.Add(tbxFullName, 2, 4);
            tableLayoutPanel5.Controls.Add(cbxGender, 2, 5);
            tableLayoutPanel5.Controls.Add(tbxAddress, 2, 7);
            tableLayoutPanel5.Controls.Add(lblAgeFrom, 0, 8);
            tableLayoutPanel5.Controls.Add(tbxEmail, 2, 8);
            tableLayoutPanel5.Controls.Add(lblAgeTo, 0, 0);
            tableLayoutPanel5.Controls.Add(label1, 1, 9);
            tableLayoutPanel5.Controls.Add(panel5, 2, 9);
            tableLayoutPanel5.Controls.Add(tbxPhone, 2, 6);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 10;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            tableLayoutPanel5.Size = new Size(1169, 476);
            tableLayoutPanel5.TabIndex = 7;
            tableLayoutPanel5.Paint += tableLayoutPanel5_Paint;
            // 
            // tbxFullName
            // 
            tbxFullName.Dock = DockStyle.Top;
            tbxFullName.Location = new Point(235, 87);
            tbxFullName.Name = "tbxFullName";
            tbxFullName.Size = new Size(931, 23);
            tbxFullName.TabIndex = 15;
            // 
            // cbxGender
            // 
            cbxGender.Dock = DockStyle.Top;
            cbxGender.FormattingEnabled = true;
            cbxGender.Location = new Point(235, 126);
            cbxGender.Name = "cbxGender";
            cbxGender.Size = new Size(931, 23);
            cbxGender.TabIndex = 16;
            // 
            // tbxAddress
            // 
            tbxAddress.Dock = DockStyle.Top;
            tbxAddress.Location = new Point(235, 209);
            tbxAddress.Multiline = true;
            tbxAddress.Name = "tbxAddress";
            tbxAddress.Size = new Size(931, 56);
            tbxAddress.TabIndex = 17;
            // 
            // tbxEmail
            // 
            tbxEmail.Dock = DockStyle.Top;
            tbxEmail.Location = new Point(235, 285);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(931, 23);
            tbxEmail.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 325);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 19;
            label1.Text = "Ngày sinh";
            // 
            // panel5
            // 
            panel5.Controls.Add(mcBirthDate);
            panel5.Controls.Add(cbxBirthDate);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(235, 328);
            panel5.Name = "panel5";
            panel5.Size = new Size(931, 145);
            panel5.TabIndex = 21;
            // 
            // mcBirthDate
            // 
            mcBirthDate.Location = new Point(0, 2);
            mcBirthDate.Name = "mcBirthDate";
            mcBirthDate.TabIndex = 1;
            mcBirthDate.Visible = false;
            mcBirthDate.DateSelected += mcBirthDate_DateSelected;
            // 
            // cbxBirthDate
            // 
            cbxBirthDate.Dock = DockStyle.Top;
            cbxBirthDate.FormattingEnabled = true;
            cbxBirthDate.Location = new Point(0, 0);
            cbxBirthDate.Name = "cbxBirthDate";
            cbxBirthDate.Size = new Size(931, 23);
            cbxBirthDate.TabIndex = 0;
            cbxBirthDate.Click += cbxBirthDate_Click;
            // 
            // tbxPhone
            // 
            tbxPhone.Dock = DockStyle.Top;
            tbxPhone.Location = new Point(235, 168);
            tbxPhone.Name = "tbxPhone";
            tbxPhone.Size = new Size(931, 23);
            tbxPhone.TabIndex = 22;
            // 
            // frmFillCandidateProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 547);
            Name = "frmFillCandidateProfile";
            Text = "frmFillCandidateProfile";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel5;
        private Label label8;
        private TextBox tbxCode;
        private Label label10;
        private Label label11;
        private Label label9;
        private Label label13;
        private Label lblAgeFrom;
        private Label label12;
        private Label lblAgeTo;
        private Label lblQuanity;
        private TextBox tbxFullName;
        private ComboBox cbxGender;
        private TextBox tbxAddress;
        private TextBox tbxEmail;
        private Label label1;
        private Panel panel5;
        private MonthCalendar mcBirthDate;
        private ComboBox cbxBirthDate;
        private TextBox tbxPhone;
    }
}
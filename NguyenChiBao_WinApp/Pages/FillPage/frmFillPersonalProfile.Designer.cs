namespace NguyenChiBao_WinApp.Pages.FillPage
{
    partial class frmFillPersonalProfile
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
            panel5 = new Panel();
            pb = new PictureBox();
            btnUpload = new Button();
            panel6 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label16 = new Label();
            label10 = new Label();
            tbxTemporaryAddress = new TextBox();
            label9 = new Label();
            tbxHometown = new TextBox();
            tbxPermanentAddress = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbxEthnicity = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tbxCode = new TextBox();
            tbxName = new TextBox();
            tbxGender = new ComboBox();
            tbxIdentificationCard = new TextBox();
            tbxNationality = new TextBox();
            dtpDateEmploy = new DateTimePicker();
            label4 = new Label();
            dtpBirthDate = new DateTimePicker();
            label8 = new Label();
            label11 = new Label();
            label12 = new Label();
            tbxPhone = new TextBox();
            label13 = new Label();
            tbxEmail = new TextBox();
            label14 = new Label();
            label15 = new Label();
            tbxDepartment = new TextBox();
            label17 = new Label();
            tbxTax = new TextBox();
            cbxEducationLevel = new ComboBox();
            label18 = new Label();
            tbxReligion = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            cbxCandidateProfile = new ComboBox();
            label19 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb).BeginInit();
            panel6.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Size = new Size(1164, 37);
            // 
            // panel3
            // 
            panel3.Location = new Point(964, 0);
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.Red;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Red;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 501);
            panel1.Size = new Size(1164, 44);
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Size = new Size(1164, 464);
            // 
            // panel5
            // 
            panel5.Controls.Add(pb);
            panel5.Controls.Add(btnUpload);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1164, 404);
            panel5.TabIndex = 0;
            // 
            // pb
            // 
            pb.BackgroundImage = Properties.Resources.test_account_100px;
            pb.BackgroundImageLayout = ImageLayout.Stretch;
            pb.Location = new Point(23, 16);
            pb.Name = "pb";
            pb.Size = new Size(143, 146);
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.TabIndex = 5;
            pb.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(18, 168);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(148, 23);
            btnUpload.TabIndex = 4;
            btnUpload.Text = "Tải ảnh lên";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(tableLayoutPanel1);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(192, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(972, 404);
            panel6.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.7189541F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.281044F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 382F));
            tableLayoutPanel1.Controls.Add(label16, 0, 8);
            tableLayoutPanel1.Controls.Add(tbxEthnicity, 1, 10);
            tableLayoutPanel1.Controls.Add(tbxName, 1, 3);
            tableLayoutPanel1.Controls.Add(label10, 0, 6);
            tableLayoutPanel1.Controls.Add(tbxTemporaryAddress, 1, 6);
            tableLayoutPanel1.Controls.Add(label9, 0, 5);
            tableLayoutPanel1.Controls.Add(tbxHometown, 3, 5);
            tableLayoutPanel1.Controls.Add(tbxPermanentAddress, 1, 5);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 2, 1);
            tableLayoutPanel1.Controls.Add(label6, 2, 2);
            tableLayoutPanel1.Controls.Add(label7, 2, 3);
            tableLayoutPanel1.Controls.Add(tbxCode, 1, 1);
            tableLayoutPanel1.Controls.Add(tbxGender, 3, 1);
            tableLayoutPanel1.Controls.Add(tbxIdentificationCard, 3, 2);
            tableLayoutPanel1.Controls.Add(tbxNationality, 3, 3);
            tableLayoutPanel1.Controls.Add(dtpDateEmploy, 3, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(dtpBirthDate, 1, 4);
            tableLayoutPanel1.Controls.Add(label8, 2, 4);
            tableLayoutPanel1.Controls.Add(label11, 2, 5);
            tableLayoutPanel1.Controls.Add(label12, 2, 6);
            tableLayoutPanel1.Controls.Add(tbxPhone, 3, 6);
            tableLayoutPanel1.Controls.Add(label13, 0, 7);
            tableLayoutPanel1.Controls.Add(tbxEmail, 1, 7);
            tableLayoutPanel1.Controls.Add(label14, 2, 7);
            tableLayoutPanel1.Controls.Add(label15, 2, 8);
            tableLayoutPanel1.Controls.Add(tbxDepartment, 3, 7);
            tableLayoutPanel1.Controls.Add(label17, 0, 9);
            tableLayoutPanel1.Controls.Add(tbxTax, 1, 9);
            tableLayoutPanel1.Controls.Add(cbxEducationLevel, 3, 8);
            tableLayoutPanel1.Controls.Add(label18, 2, 9);
            tableLayoutPanel1.Controls.Add(tbxReligion, 3, 9);
            tableLayoutPanel1.Controls.Add(cbxCandidateProfile, 1, 2);
            tableLayoutPanel1.Controls.Add(label19, 0, 10);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 36.50794F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 63.49206F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(972, 404);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(3, 281);
            label16.Name = "label16";
            label16.Size = new Size(103, 15);
            label16.TabIndex = 28;
            label16.Text = "15. Vị trí công việc";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 202);
            label10.Name = "label10";
            label10.Size = new Size(97, 15);
            label10.TabIndex = 2;
            label10.Text = "9. Địa chỉ tạm trú";
            // 
            // tbxTemporaryAddress
            // 
            tbxTemporaryAddress.Location = new Point(141, 205);
            tbxTemporaryAddress.Name = "tbxTemporaryAddress";
            tbxTemporaryAddress.Size = new Size(302, 23);
            tbxTemporaryAddress.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 161);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 1;
            label9.Text = "8. Địa chỉ";
            // 
            // tbxHometown
            // 
            tbxHometown.Location = new Point(592, 164);
            tbxHometown.Name = "tbxHometown";
            tbxHometown.Size = new Size(377, 23);
            tbxHometown.TabIndex = 16;
            tbxHometown.TextChanged += textBox9_TextChanged;
            // 
            // tbxPermanentAddress
            // 
            tbxPermanentAddress.Location = new Point(141, 164);
            tbxPermanentAddress.Name = "tbxPermanentAddress";
            tbxPermanentAddress.Size = new Size(302, 23);
            tbxPermanentAddress.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 18);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "1. Mã nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 50);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "2. Mã hồ sơ";
            // 
            // tbxEthnicity
            // 
            tbxEthnicity.Location = new Point(141, 357);
            tbxEthnicity.Name = "tbxEthnicity";
            tbxEthnicity.Size = new Size(305, 23);
            tbxEthnicity.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 85);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "3. Họ và tên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(452, 18);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 4;
            label5.Text = "4. Giới tính\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(452, 50);
            label6.Name = "label6";
            label6.Size = new Size(122, 15);
            label6.TabIndex = 5;
            label6.Text = "5. Căn cước công dân\r\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(452, 85);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 6;
            label7.Text = "6. Quốc tịch";
            // 
            // tbxCode
            // 
            tbxCode.Location = new Point(141, 21);
            tbxCode.Name = "tbxCode";
            tbxCode.Size = new Size(305, 23);
            tbxCode.TabIndex = 8;
            // 
            // tbxName
            // 
            tbxName.Location = new Point(141, 88);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(305, 23);
            tbxName.TabIndex = 9;
            tbxName.TextChanged += tbxName_TextChanged;
            // 
            // tbxGender
            // 
            tbxGender.FormattingEnabled = true;
            tbxGender.Location = new Point(592, 21);
            tbxGender.Name = "tbxGender";
            tbxGender.Size = new Size(377, 23);
            tbxGender.TabIndex = 12;
            // 
            // tbxIdentificationCard
            // 
            tbxIdentificationCard.Location = new Point(592, 53);
            tbxIdentificationCard.Name = "tbxIdentificationCard";
            tbxIdentificationCard.Size = new Size(377, 23);
            tbxIdentificationCard.TabIndex = 13;
            // 
            // tbxNationality
            // 
            tbxNationality.Location = new Point(592, 88);
            tbxNationality.Name = "tbxNationality";
            tbxNationality.Size = new Size(377, 23);
            tbxNationality.TabIndex = 14;
            // 
            // dtpDateEmploy
            // 
            dtpDateEmploy.Location = new Point(592, 124);
            dtpDateEmploy.Name = "dtpDateEmploy";
            dtpDateEmploy.Size = new Size(377, 23);
            dtpDateEmploy.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 121);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 19;
            label4.Text = "7. Ngày sinh";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(141, 124);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(302, 23);
            dtpBirthDate.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(452, 121);
            label8.Name = "label8";
            label8.Size = new Size(98, 15);
            label8.TabIndex = 3;
            label8.Text = "10. Ngày vào làm";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(452, 161);
            label11.Name = "label11";
            label11.Size = new Size(77, 15);
            label11.TabIndex = 4;
            label11.Text = "11. Quê quán";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(452, 202);
            label12.Name = "label12";
            label12.Size = new Size(94, 15);
            label12.TabIndex = 21;
            label12.Text = "12. Số điện thoại";
            // 
            // tbxPhone
            // 
            tbxPhone.Dock = DockStyle.Top;
            tbxPhone.Location = new Point(592, 205);
            tbxPhone.Name = "tbxPhone";
            tbxPhone.Size = new Size(377, 23);
            tbxPhone.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 244);
            label13.Name = "label13";
            label13.Size = new Size(54, 15);
            label13.TabIndex = 23;
            label13.Text = "13. Email";
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(141, 247);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(302, 23);
            tbxEmail.TabIndex = 24;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(452, 244);
            label14.Name = "label14";
            label14.Size = new Size(83, 15);
            label14.TabIndex = 25;
            label14.Text = "14. Phòng ban";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(452, 281);
            label15.Name = "label15";
            label15.Size = new Size(113, 15);
            label15.TabIndex = 26;
            label15.Text = "16. Trình độ văn hóa";
            // 
            // tbxDepartment
            // 
            tbxDepartment.Dock = DockStyle.Top;
            tbxDepartment.Location = new Point(592, 247);
            tbxDepartment.Name = "tbxDepartment";
            tbxDepartment.Size = new Size(377, 23);
            tbxDepartment.TabIndex = 30;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(3, 314);
            label17.Name = "label17";
            label17.Size = new Size(84, 15);
            label17.TabIndex = 31;
            label17.Text = "17. Mã số thuế";
            // 
            // tbxTax
            // 
            tbxTax.Location = new Point(141, 317);
            tbxTax.Name = "tbxTax";
            tbxTax.Size = new Size(302, 23);
            tbxTax.TabIndex = 32;
            // 
            // cbxEducationLevel
            // 
            cbxEducationLevel.Dock = DockStyle.Top;
            cbxEducationLevel.FormattingEnabled = true;
            cbxEducationLevel.Location = new Point(592, 284);
            cbxEducationLevel.Name = "cbxEducationLevel";
            cbxEducationLevel.Size = new Size(377, 23);
            cbxEducationLevel.TabIndex = 33;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(452, 314);
            label18.Name = "label18";
            label18.Size = new Size(70, 15);
            label18.TabIndex = 34;
            label18.Text = "18. Tôn giáo";
            // 
            // tbxReligion
            // 
            tbxReligion.Dock = DockStyle.Top;
            tbxReligion.Location = new Point(592, 317);
            tbxReligion.Name = "tbxReligion";
            tbxReligion.Size = new Size(377, 23);
            tbxReligion.TabIndex = 35;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbxCandidateProfile
            // 
            cbxCandidateProfile.FormattingEnabled = true;
            cbxCandidateProfile.Location = new Point(141, 53);
            cbxCandidateProfile.Name = "cbxCandidateProfile";
            cbxCandidateProfile.Size = new Size(305, 23);
            cbxCandidateProfile.TabIndex = 36;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(3, 354);
            label19.Name = "label19";
            label19.Size = new Size(66, 15);
            label19.TabIndex = 37;
            label19.Text = "19. Dân tộc";
            // 
            // frmFillPersonalProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 545);
            Name = "frmFillPersonalProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFillPersonalProfile";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb).EndInit();
            panel6.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel;
        #endregion

        private Panel panel5;
        private PictureBox pictureBox1;
        private Panel panel6;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tbxCode;
        private TextBox tbxName;
        private ComboBox tbxGender;
        private TextBox tbxIdentificationCard;
        private TextBox tbxNationality;
        private Button button1;
        private TextBox tbxTemporaryAddress;
        private TextBox tbxPermanentAddress;
        private Label label10;
        private Label label9;
        private Label label11;
        private Label label8;
        private TextBox tbxHometown;
        private TextBox tbxEthnicity;
        private DateTimePicker dtpDateEmploy;
        private Label label4;
        private DateTimePicker dtpBirthDate;
        private Label label16;
        private Label label12;
        private TextBox tbxPhone;
        private Label label13;
        private TextBox tbxEmail;
        private Label label14;
        private Label label15;
        private TextBox textBox11;
        private TextBox tbxDepartment;
        private TextBox textBox12;
        private Label label17;
        private TextBox tbxTax;
        private ComboBox cbxEducationLevel;
        private Button btnUpload;
        private Label label18;
        private TextBox tbxReligion;
        private OpenFileDialog openFileDialog1;
        private PictureBox pb;
        private ComboBox cbxCandidateProfile;
        private Label label19;
    }
}
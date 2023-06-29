namespace NguyenChiBao_WinApp.Pages.FillPage
{
    partial class frmFillEmployeeContract
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
            label6 = new Label();
            tbxCode = new TextBox();
            cbxDepartment = new ComboBox();
            cbxEmployee = new ComboBox();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            cbxContractType = new ComboBox();
            label7 = new Label();
            tbxDescription = new TextBox();
            panel5 = new Panel();
            button2 = new Button();
            cbxAlllowance = new ComboBox();
            cbxSalaryGrade = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            dtSalary = new DataGridView();
            Parameter = new DataGridViewTextBoxColumn();
            Coei = new DataGridViewTextBoxColumn();
            Sum = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            panel6 = new Panel();
            lblSalaryContract = new Label();
            label13 = new Label();
            lblSumAllowance = new Label();
            label9 = new Label();
            lblMinSalary = new Label();
            label8 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtSalary).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Size = new Size(1153, 37);
            // 
            // panel3
            // 
            panel3.Location = new Point(953, 0);
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
            panel1.Size = new Size(1153, 44);
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel1);
            panel4.Size = new Size(1153, 466);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.3709679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.6290359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 872F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 12F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 1, 3);
            tableLayoutPanel1.Controls.Add(label4, 1, 4);
            tableLayoutPanel1.Controls.Add(label5, 1, 5);
            tableLayoutPanel1.Controls.Add(label6, 1, 6);
            tableLayoutPanel1.Controls.Add(tbxCode, 2, 1);
            tableLayoutPanel1.Controls.Add(cbxDepartment, 2, 2);
            tableLayoutPanel1.Controls.Add(cbxEmployee, 2, 3);
            tableLayoutPanel1.Controls.Add(dtpEndDate, 2, 6);
            tableLayoutPanel1.Controls.Add(dtpStartDate, 2, 5);
            tableLayoutPanel1.Controls.Add(cbxContractType, 2, 4);
            tableLayoutPanel1.Controls.Add(label7, 1, 7);
            tableLayoutPanel1.Controls.Add(tbxDescription, 2, 7);
            tableLayoutPanel1.Controls.Add(panel5, 2, 8);
            tableLayoutPanel1.Controls.Add(panel6, 1, 8);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.3243237F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75.6756744F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 165F));
            tableLayoutPanel1.Size = new Size(1153, 466);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 12);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "1. Mã hợp đồng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 50);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "2. Bộ phận";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 87);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "4. Nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 125);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 3;
            label4.Text = "5. Loại hợp đồng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 164);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 4;
            label5.Text = "Ngày bắt đầu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 202);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 5;
            label6.Text = "Ngày kết thúc";
            // 
            // tbxCode
            // 
            tbxCode.Dock = DockStyle.Fill;
            tbxCode.Location = new Point(251, 15);
            tbxCode.Name = "tbxCode";
            tbxCode.Size = new Size(866, 23);
            tbxCode.TabIndex = 6;
            // 
            // cbxDepartment
            // 
            cbxDepartment.Dock = DockStyle.Fill;
            cbxDepartment.FormattingEnabled = true;
            cbxDepartment.Location = new Point(251, 53);
            cbxDepartment.Name = "cbxDepartment";
            cbxDepartment.Size = new Size(866, 23);
            cbxDepartment.TabIndex = 7;
            cbxDepartment.SelectedIndexChanged += cbxDepartment_SelectedIndexChanged;
            // 
            // cbxEmployee
            // 
            cbxEmployee.Dock = DockStyle.Fill;
            cbxEmployee.FormattingEnabled = true;
            cbxEmployee.Location = new Point(251, 90);
            cbxEmployee.Name = "cbxEmployee";
            cbxEmployee.Size = new Size(866, 23);
            cbxEmployee.TabIndex = 10;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(251, 205);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(200, 23);
            dtpEndDate.TabIndex = 8;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(251, 167);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 9;
            // 
            // cbxContractType
            // 
            cbxContractType.Dock = DockStyle.Fill;
            cbxContractType.FormattingEnabled = true;
            cbxContractType.Location = new Point(251, 128);
            cbxContractType.Name = "cbxContractType";
            cbxContractType.Size = new Size(866, 23);
            cbxContractType.TabIndex = 11;
            cbxContractType.SelectedIndexChanged += cbxContractType_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 245);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 12;
            label7.Text = "Nơi làm việc";
            // 
            // tbxDescription
            // 
            tbxDescription.Dock = DockStyle.Fill;
            tbxDescription.Location = new Point(251, 248);
            tbxDescription.Multiline = true;
            tbxDescription.Name = "tbxDescription";
            tbxDescription.Size = new Size(866, 49);
            tbxDescription.TabIndex = 13;
            // 
            // panel5
            // 
            panel5.Controls.Add(button2);
            panel5.Controls.Add(cbxAlllowance);
            panel5.Controls.Add(cbxSalaryGrade);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(dtSalary);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(251, 303);
            panel5.Name = "panel5";
            panel5.Size = new Size(866, 160);
            panel5.TabIndex = 14;
            // 
            // button2
            // 
            button2.Location = new Point(229, 90);
            button2.Name = "button2";
            button2.Size = new Size(121, 23);
            button2.TabIndex = 7;
            button2.Text = "Thêm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cbxAlllowance
            // 
            cbxAlllowance.FormattingEnabled = true;
            cbxAlllowance.Location = new Point(102, 90);
            cbxAlllowance.Name = "cbxAlllowance";
            cbxAlllowance.Size = new Size(121, 23);
            cbxAlllowance.TabIndex = 5;
            // 
            // cbxSalaryGrade
            // 
            cbxSalaryGrade.FormattingEnabled = true;
            cbxSalaryGrade.Location = new Point(102, 51);
            cbxSalaryGrade.Name = "cbxSalaryGrade";
            cbxSalaryGrade.Size = new Size(121, 23);
            cbxSalaryGrade.TabIndex = 3;
            cbxSalaryGrade.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 93);
            label12.Name = "label12";
            label12.Size = new Size(50, 15);
            label12.TabIndex = 2;
            label12.Text = "Phụ cấp";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 51);
            label11.Name = "label11";
            label11.Size = new Size(80, 15);
            label11.TabIndex = 1;
            label11.Text = "Lương cơ bản";
            // 
            // dtSalary
            // 
            dtSalary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtSalary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtSalary.Columns.AddRange(new DataGridViewColumn[] { Parameter, Coei, Sum, Id });
            dtSalary.Location = new Point(380, 7);
            dtSalary.Name = "dtSalary";
            dtSalary.RowTemplate.Height = 25;
            dtSalary.Size = new Size(483, 150);
            dtSalary.TabIndex = 0;
            dtSalary.CellDoubleClick += dtSalary_CellDoubleClick;
            dtSalary.CellValueChanged += dtSalary_CellValueChanged;
            // 
            // Parameter
            // 
            Parameter.HeaderText = "Tham số lương";
            Parameter.Name = "Parameter";
            Parameter.ReadOnly = true;
            // 
            // Coei
            // 
            Coei.HeaderText = "Hệ số";
            Coei.Name = "Coei";
            Coei.ReadOnly = true;
            // 
            // Sum
            // 
            Sum.HeaderText = "Mức hưởng";
            Sum.Name = "Sum";
            Sum.ReadOnly = true;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(lblSalaryContract);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(lblSumAllowance);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(lblMinSalary);
            panel6.Controls.Add(label8);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(56, 303);
            panel6.Name = "panel6";
            panel6.Size = new Size(189, 160);
            panel6.TabIndex = 15;
            // 
            // lblSalaryContract
            // 
            lblSalaryContract.AutoSize = true;
            lblSalaryContract.Location = new Point(120, 98);
            lblSalaryContract.Name = "lblSalaryContract";
            lblSalaryContract.Size = new Size(13, 15);
            lblSalaryContract.TabIndex = 7;
            lblSalaryContract.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(2, 98);
            label13.Name = "label13";
            label13.Size = new Size(96, 15);
            label13.TabIndex = 6;
            label13.Text = "Lương hợp đồng";
            // 
            // lblSumAllowance
            // 
            lblSumAllowance.AutoSize = true;
            lblSumAllowance.Location = new Point(120, 51);
            lblSumAllowance.Name = "lblSumAllowance";
            lblSumAllowance.Size = new Size(13, 15);
            lblSumAllowance.TabIndex = 5;
            lblSumAllowance.Text = "0";
            lblSumAllowance.Click += label12_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 51);
            label9.Name = "label9";
            label9.Size = new Size(80, 15);
            label9.TabIndex = 4;
            label9.Text = "Tổng phụ cấp";
            label9.Click += label9_Click;
            // 
            // lblMinSalary
            // 
            lblMinSalary.AutoSize = true;
            lblMinSalary.Location = new Point(120, 3);
            lblMinSalary.Name = "lblMinSalary";
            lblMinSalary.Size = new Size(0, 15);
            lblMinSalary.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(2, 3);
            label8.Name = "label8";
            label8.Size = new Size(112, 15);
            label8.TabIndex = 0;
            label8.Text = "Mức lương tối thiểu";
            // 
            // frmFillEmployeeContract
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 547);
            Name = "frmFillEmployeeContract";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFillEmployeeContract";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtSalary).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbxCode;
        private ComboBox cbxDepartment;
        private ComboBox cbxEmployee;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private ComboBox cbxContractType;
        private Label label7;
        private TextBox tbxDescription;
        private Panel panel5;

        private Panel panel6;
        private Label lblMinSalary;
        private Label label8;
        private Label lblSalaryContract;
        private Label label13;
        private Label lblSumAllowance;
        private Label label9;
        private Button button2;
        private ComboBox cbxAlllowance;
        private ComboBox cbxSalaryGrade;
        private Label label12;
        private Label label11;
        private DataGridView dtSalary;
        private DataGridViewTextBoxColumn Parameter;
        private DataGridViewTextBoxColumn Coei;
        private DataGridViewTextBoxColumn Sum;
        private DataGridViewTextBoxColumn Id;
    }
}
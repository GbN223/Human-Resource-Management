namespace NguyenChiBao_WinApp.Pages.ListPage
{
    partial class frmListParent
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
            panel6 = new Panel();
            btnAdd = new Button();
            button3 = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(955, 40);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnAdd);
            panel6.Controls.Add(button3);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(717, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(238, 40);
            panel6.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(82, 9);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "button4";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(3, 9);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 0;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(textBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(552, 40);
            panel3.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(comboBox2);
            panel5.Controls.Add(comboBox1);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(button1);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(215, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(337, 40);
            panel5.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(213, 10);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(90, 11);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Left;
            button2.Location = new Point(40, 0);
            button2.Name = "button2";
            button2.Size = new Size(40, 40);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 23);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(955, 443);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(955, 421);
            dataGridView1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(955, 22);
            panel4.TabIndex = 0;
            // 
            // frmListParent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 483);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmListParent";
            Text = "frmListRecruitmentRequirement";
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        protected Panel panel1;
        protected Panel panel3;
        protected Panel panel5;
        protected Button button1;
        protected TextBox textBox1;
        protected Panel panel2;
        protected DataGridView dataGridView1;
        protected Panel panel4;
        protected ComboBox comboBox2;
        protected ComboBox comboBox1;
        protected Button button2;
        protected Panel panel6;
        protected Button btnAdd;
        protected Button button3;
    }
}
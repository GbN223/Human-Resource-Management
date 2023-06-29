namespace NguyenChiBao_WinApp
{
    partial class LoginFrom
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
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            label1 = new Label();
            tbxUser = new TextBox();
            tbxPass = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 23);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.icons8_close_15px;
            button1.Location = new Point(277, 0);
            button1.Name = "button1";
            button1.Size = new Size(36, 23);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.unnamed;
            pictureBox1.Location = new Point(106, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 168, 142);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(55, 349);
            button2.Name = "button2";
            button2.Size = new Size(200, 37);
            button2.TabIndex = 5;
            button2.Text = "Đăng nhập";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(79, 173);
            label1.Name = "label1";
            label1.Size = new Size(152, 15);
            label1.TabIndex = 6;
            label1.Text = "Chào mừng đến với Bravo";
            // 
            // tbxUser
            // 
            tbxUser.BackColor = Color.White;
            tbxUser.BorderStyle = BorderStyle.None;
            tbxUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxUser.Location = new Point(55, 229);
            tbxUser.Margin = new Padding(1, 3, 3, 3);
            tbxUser.Name = "tbxUser";
            tbxUser.Size = new Size(200, 18);
            tbxUser.TabIndex = 7;
            // 
            // tbxPass
            // 
            tbxPass.BorderStyle = BorderStyle.None;
            tbxPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxPass.Location = new Point(55, 290);
            tbxPass.Margin = new Padding(1, 3, 3, 3);
            tbxPass.Name = "tbxPass";
            tbxPass.Size = new Size(200, 18);
            tbxPass.TabIndex = 8;
            tbxPass.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(313, 456);
            Controls.Add(tbxPass);
            Controls.Add(tbxUser);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Label label1;
        private TextBox tbxUser;
        private TextBox tbxPass;
    }
}
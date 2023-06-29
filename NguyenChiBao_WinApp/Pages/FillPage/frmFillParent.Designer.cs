namespace NguyenChiBao_WinApp.Pages.FillPage
{
    partial class frmFillParent
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
            panel2 = new Panel();
            panel3 = new Panel();
            btnClose = new Button();
            panel1 = new Panel();
            btnSaveBack = new Button();
            btnSave = new Button();
            panel4 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(927, 37);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnClose);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(727, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 37);
            panel3.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.Red;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.icons8_close_15px;
            btnClose.Location = new Point(163, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(37, 23);
            btnClose.TabIndex = 4;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSaveBack);
            panel1.Controls.Add(btnSave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 455);
            panel1.Name = "panel1";
            panel1.Size = new Size(927, 44);
            panel1.TabIndex = 3;
            // 
            // btnSaveBack
            // 
            btnSaveBack.Dock = DockStyle.Left;
            btnSaveBack.Location = new Point(120, 0);
            btnSaveBack.Name = "btnSaveBack";
            btnSaveBack.Size = new Size(111, 44);
            btnSaveBack.TabIndex = 1;
            btnSaveBack.Text = "Lưu và quay ra";
            btnSaveBack.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Left;
            btnSave.Location = new Point(0, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 44);
            btnSave.TabIndex = 0;
            btnSave.Text = "Lưu và thêm mới";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 37);
            panel4.Name = "panel4";
            panel4.Size = new Size(927, 418);
            panel4.TabIndex = 4;
            // 
            // frmFillParent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 499);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFillParent";
            Text = "frmFillParent";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        protected Panel panel2;
        protected Panel panel3;
        protected Button btnClose;
        protected Panel panel1;
        protected Button btnSaveBack;
        protected Button btnSave;

        protected Panel panel4;
    }
}
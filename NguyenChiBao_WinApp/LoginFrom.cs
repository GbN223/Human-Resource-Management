namespace NguyenChiBao_WinApp
{
    public partial class LoginFrom : Form
    {
        public LoginFrom()
        {
            InitializeComponent();
            tbxUser.Height = 37;
            tbxPass.Height = 37;
            BorderPanel();
            PictureIconTextbox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void BorderPanel()
        {
            Panel borderUserPanel = new Panel();
            borderUserPanel.BackColor = ColorTranslator.FromHtml("#FF00A88E"); ; // Set the border color
            borderUserPanel.Height = 1; // Set the border thickness

            // Position the Panel control below the TextBox control
            borderUserPanel.Width = tbxUser.Width - 2;
            borderUserPanel.Left = tbxUser.Left + 1;
            borderUserPanel.Top = tbxUser.Top + tbxUser.Height + 10;

            // Add the Panel control to the form's controls
            this.Controls.Add(borderUserPanel);

            Panel borderPassPanel = new Panel();
            borderPassPanel.BackColor = ColorTranslator.FromHtml("#FF00A88E"); ; // Set the border color
            borderPassPanel.Height = 1; // Set the border thickness

            // Position the Panel control below the TextBox control
            borderPassPanel.Width = tbxPass.Width - 2;
            borderPassPanel.Left = tbxPass.Left + 1;
            borderPassPanel.Top = tbxPass.Top + tbxUser.Height + 10;

            // Add the Panel control to the form's controls
            this.Controls.Add(borderPassPanel);
        }
        private void PictureIconTextbox()
        {
            PictureBox iconUser = new PictureBox();
            iconUser.Image = Properties.Resources.icons8_user_20px; // Set the image for the user icon
            iconUser.SizeMode = PictureBoxSizeMode.CenterImage;
            iconUser.Width = 15;
            iconUser.Height = 15;

            iconUser.Location = new Point(tbxUser.Left, tbxUser.Top + ((tbxUser.Height - iconUser.Height) / 2)); // Position the user icon to the left of the TextBox

            PictureBox iconPass = new PictureBox();
            iconPass.Image = Properties.Resources.icons8_Key_Security_20px; // Set the image for the password icon
            iconPass.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPass.Location = new Point(tbxPass.Left, tbxPass.Top + ((tbxPass.Height - iconPass.Height) / 2)); // Position the password icon to the left of the TextBox
            iconPass.Width = 15;
            this.Controls.Add(iconUser);
            this.Controls.Add(iconPass);

            tbxUser.Left = iconUser.Right + 5; // Position the TextBox after the user icon
            tbxUser.Width = this.Width - tbxUser.Left - 20; // Adjust the width of the TextBox to fit the remaining space

            tbxPass.Left = iconPass.Right + 5; // Position the TextBox after the password icon
            tbxPass.Width = this.Width - tbxPass.Left - 20; // Adjust the width of the TextBox to fit the remaining space
            tbxUser.PlaceholderText = "Tên đăng nhập";
            tbxPass.PlaceholderText = "Mật khẩu";
        }
    }
}
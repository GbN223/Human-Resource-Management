using NguyenChiBao_WinApp.Pages.FillPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenChiBao_WinApp.Pages.ListPage
{
    public partial class frmListProfilePersonal : frmListParent
    {
        public frmListProfilePersonal()
        {
            InitializeComponent();
            btnAdd.Click += BtnAdd_Click;
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            frmFillPersonalProfile frmFillPersonalProfile = new frmFillPersonalProfile();
            frmFillPersonalProfile.WindowState = FormWindowState.Normal;
            frmFillPersonalProfile.Width = 1169;
            frmFillPersonalProfile.Height= 547;
        frmFillPersonalProfile.StartPosition= FormStartPosition.CenterScreen;
            frmFillPersonalProfile.ShowDialog();
        }
    }
}

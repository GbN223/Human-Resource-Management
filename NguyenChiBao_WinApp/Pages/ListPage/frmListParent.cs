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
    public partial class frmListParent : Form
    {
        public frmListParent()
        {

            InitializeComponent();
            btnAdd.Click += BtnAdd_Click;

        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Hide();
        }
    }
}

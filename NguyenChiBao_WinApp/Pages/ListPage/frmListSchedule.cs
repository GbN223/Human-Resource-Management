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
    public partial class frmListSchedule : frmListParent
    {
        public frmListSchedule()
        {
            InitializeComponent();
            btnAdd.Click += BtnAdd_Click;
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            frmFillSchedule frmFillSchedule = new frmFillSchedule();
            frmFillSchedule.StartPosition = FormStartPosition.CenterScreen;
            frmFillSchedule.ShowDialog();
        }
    }
}

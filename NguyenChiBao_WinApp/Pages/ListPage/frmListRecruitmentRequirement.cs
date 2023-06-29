﻿using NguyenChiBao_WinApp.Pages.FillPage;
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
    public partial class frmListRecruitmentRequirement : frmListParent
    {
        public frmListRecruitmentRequirement( )
        {
            InitializeComponent();
            btnAdd.Click += BtnAdd_Click;
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
         
            frmFillRecruitmentRequirement frmFillRecruitmentRequirement = new frmFillRecruitmentRequirement();
            frmFillRecruitmentRequirement.WindowState= FormWindowState.Normal;
            frmFillRecruitmentRequirement.ShowDialog();
            
        }
    }
}

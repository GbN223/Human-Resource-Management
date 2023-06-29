
using NguyenChiBao_WinApp.Pages.FillPage;
using NguyenChiBao_WinApp.Pages.ListPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenChiBao_WinApp
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            LoadPage();

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnNormal.Visible = true;
        }

        private void btnNormal_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMax.Visible = true;
            btnNormal.Visible = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string fileName = @"E:\HKII_2023\HocWPF\GunaUI\Docs\DeAnTotNghiep.htm"; // Thay đổi tên file nếu cần
            System.Diagnostics.Process process = new System.Diagnostics.Process();

            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = fileName
            };

            process.Start();

        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnParent.Controls.Add(childForm);
            pnParent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {


        }
        private void LoadPage()
        {

            if (this.WindowState == FormWindowState.Normal)
            {
                btnMax.Visible = true;
                btnNormal.Visible = false;
            }
            pnLuong.Visible = false;
            pnTuyendung.Visible = false;
            pnLuong.Visible = false;
            pnNhansu.Visible = false;
            pnDaotao.Visible = false;
            pnChamcong.Visible = false;
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            // panel1.VerticalScroll.Value = e.NewValue;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if (pnTuyendung.Visible)
            {
                pnTuyendung.Visible = false;
            }
            else
            {
                pnTuyendung.Visible = true;
            }
        }

        private void menuTraining_Click(object sender, EventArgs e)
        {
            if (pnDaotao.Visible)
            {
                pnDaotao.Visible = false;
            }
            else
            {
                pnDaotao.Visible = true;
            }
        }

        private void menuEmployment_Click(object sender, EventArgs e)
        {
            if (pnNhansu.Visible)
            {
                pnNhansu.Visible = false;
            }
            else
            {
                pnNhansu.Visible = true;
            }
        }

        private void menuTimekeeping_Click(object sender, EventArgs e)
        {

            if (pnChamcong.Visible)
            {
                pnChamcong.Visible = false;
            }
            else
            {
                pnChamcong.Visible = true;
            }
        }

        private void menuSalary_Click(object sender, EventArgs e)
        {

            if (pnLuong.Visible)
            {
                pnLuong.Visible = false;
            }
            else
            {
                pnLuong.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmListRecruitmentRequirement frmListRecruitmentRequirement = new frmListRecruitmentRequirement();
            openChildFormInPanel(frmListRecruitmentRequirement);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmListSchedule frmListSchedule = new frmListSchedule();
            openChildFormInPanel(frmListSchedule);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            frmListProfilePersonal frmListProfile = new frmListProfilePersonal();
            openChildFormInPanel(frmListProfile);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmListRecruitmentPlan frmListRecruitmentPlan = new frmListRecruitmentPlan();
            openChildFormInPanel((frmListRecruitmentPlan));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmListCandidateProfile frmListCandidateProfile = new frmListCandidateProfile();
            openChildFormInPanel(((frmListCandidateProfile)));
        }

        private void button14_Click(object sender, EventArgs e)
        {
            frmListEmployeeContract frmListEmployeeContract = new frmListEmployeeContract();
            openChildFormInPanel(frmListEmployeeContract);
        }
    }
}

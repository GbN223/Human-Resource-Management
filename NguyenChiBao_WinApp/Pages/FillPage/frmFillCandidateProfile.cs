using NguyenChiBao_WinApp.Contexts;
using NguyenChiBao_WinApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NguyenChiBao_WinApp.Pages.FillPage
{
    public partial class frmFillCandidateProfile : frmFillParent
    {
        CandidateProfile candidateProfile;
        CandidateProfileContext candidateProfileContext;
        public frmFillCandidateProfile()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnSaveBack.Click += BtnSaveBack_Click;
        }

        private void BtnSaveBack_Click(object? sender, EventArgs e)
        {
            try
            {
                candidateProfile = new CandidateProfile();
                candidateProfile.FullName = tbxFullName.Text;
                candidateProfile.Code = tbxCode.Text;
                candidateProfile.Gender = "Nam";//(string)cbxGender.SelectedValue;
                candidateProfile.Address = tbxAddress.Text;
                candidateProfile.Phone = tbxPhone.Text;
                candidateProfile.CreatedDate = DateTime.Now;
                candidateProfile.BirthDate = DateTime.Parse(cbxBirthDate.Text);
                candidateProfile.Email = tbxEmail.Text;
                candidateProfileContext = new CandidateProfileContext();
                candidateProfileContext.CreateCandidateProfile(candidateProfile);
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            try
            {
                candidateProfile = new CandidateProfile();
                candidateProfile.FullName = tbxFullName.Text;
                candidateProfile.Code = tbxCode.Text;
                candidateProfile.Gender = "Nam";//(string)cbxGender.SelectedValue;
                candidateProfile.Address = tbxAddress.Text;
                candidateProfile.Phone = tbxPhone.Text;
                candidateProfile.CreatedDate = DateTime.Now;
                candidateProfile.BirthDate = DateTime.Parse(cbxBirthDate.Text);
                candidateProfile.Email = tbxEmail.Text;
                candidateProfileContext = new CandidateProfileContext();
                candidateProfileContext.CreateCandidateProfile(candidateProfile);
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxBirthDate_Click(object sender, EventArgs e)
        {
            mcBirthDate.Visible = true;
        }

        private void mcBirthDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            cbxBirthDate.Text = e.Start.ToShortDateString();
            cbxBirthDate.Items.Add(e.Start.ToShortDateString());
            mcBirthDate.Visible=false;
            
        }
    }
}

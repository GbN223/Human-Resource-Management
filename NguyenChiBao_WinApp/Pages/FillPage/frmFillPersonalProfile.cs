using NguyenChiBao_WinApp.Contexts;
using NguyenChiBao_WinApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenChiBao_WinApp.Pages.FillPage
{
    public partial class frmFillPersonalProfile : frmFillParent
    {
        PersonalProfile personalProfile;
        PersonnalProfileContext profileContext;

        public frmFillPersonalProfile()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            SetTextBoxAndLabelProperties();
            LoadData();
        }
        private void SetTextBoxAndLabelProperties()
        {
            // Thiết lập font chữ và chiều cao cho Label
            Font labelFont = new Font("Arial", 20, FontStyle.Bold);
            int height = 30;
            frmFillCandidateProfile frmCandidateProfile = new frmFillCandidateProfile();

            foreach (Control control in this.Controls)
            {
                if (control is Label)
                {
                    control.Font = labelFont;
                    control.Height = height;
                }
            }
        }
        private void LoadData()
        {
            try {
                EducationLevelListContext educationLevelListContext = new EducationLevelListContext();
                cbxEducationLevel.DisplayMember = "EducationLevelName";
                cbxEducationLevel.ValueMember = "Id";
                cbxEducationLevel.DataSource = educationLevelListContext.GetAllEducationLevelLists();
            }
            catch (Exception ex) {
               
            }
            
        }
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            profileContext = new PersonnalProfileContext();
            personalProfile = new PersonalProfile();
            if (profileContext.IsPersonalProfileCodeExists(tbxCode.Text))
            {
                MessageBox.Show("Mã nhân viên vị trùng");
            }
            else {
                try
                {
                    string filePath = "";

                    if (pb.ImageLocation != null) { filePath= pb.ImageLocation; }
                    DateTime selectedDate = dtpBirthDate.Value;
                    DateTime dateTime = dtpDateEmploy.Value;
                    string formattedDate = selectedDate.ToString("MM/dd/yy");
                    string formattedDateEmploy = dateTime.ToString("MM/dd/yy");
                    personalProfile.Code = tbxCode.Text;
                    personalProfile.PersonalName = tbxName.Text;
                    personalProfile.Gender = tbxGender.Text;
                    personalProfile.DateBirth = DateTime.Parse(formattedDate);
                    personalProfile.Email = tbxEmail.Text;
                    personalProfile.Ethnicity = tbxEthnicity.Text;
                    personalProfile.Nationality = tbxNationality.Text;
                    personalProfile.IdentificationCard = tbxIdentificationCard.Text;
                    personalProfile.EducationalLevel = (int)cbxEducationLevel.SelectedValue;
                    personalProfile.Hometown = tbxHometown.Text;
                    personalProfile.PhoneNumber = tbxPhone.Text;
                    personalProfile.TaxIdentificationNumber = tbxTax.Text;
                    personalProfile.TemporaryAddress = tbxTemporaryAddress.Text;
                    personalProfile.PermanentAddress = tbxPermanentAddress.Text;
                    personalProfile.Image = filePath;
                    personalProfile.DateEmployment = DateTime.Parse(formattedDateEmploy);
                    personalProfile.Religion = tbxReligion.Text;
                    profileContext.AddPersonalProfile(personalProfile);
                    MessageBox.Show("Thêm thành công");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.Message);
                }

            }
           
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif)|*.png;*.jpg;*.jpeg;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                Bitmap bitmap = new Bitmap(openFileDialog.FileName);

                pb.Image = bitmap;

            }

        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

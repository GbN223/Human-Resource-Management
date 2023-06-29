using Microsoft.EntityFrameworkCore.Diagnostics;
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
    public partial class frmFillRecruitmentRequirement : frmFillParent
    {
        RecruitmentRequirement recruitmentRequirement;
       RecruitmentRequirementContext recruitmentContext;
        DepartmentContext departmentContext;
        EducationLevelListContext educationLevelListContext;
        PositionListContext positionListContext;
        public frmFillRecruitmentRequirement()
        {
            InitializeComponent();
            LoadData();
            btnSave.Click += BtnSave_Click;
            btnSaveBack.Click += BtnSaveBack_Click;
            
        }

      
        private void BtnSaveBack_Click(object? sender, EventArgs e)
        {
            try
            {
                recruitmentRequirement = new RecruitmentRequirement();
                recruitmentContext = new RecruitmentRequirementContext();
                DateTime dt;
                dt = DateTime.Now;

                recruitmentRequirement.Code = tbxCode.Text;
                recruitmentRequirement.Department = Int16.Parse(cbxDepartment.SelectedValue.ToString());
                recruitmentRequirement.JobPosition = Int16.Parse(cbxPosition.SelectedValue.ToString());
                recruitmentRequirement.EducationLevel = Int16.Parse(cbxEducationLevel.SelectedValue.ToString());
                recruitmentRequirement.AgeFrom = Int16.Parse(nUDAgeFrom.Value.ToString());
                recruitmentRequirement.AgeTo = Int16.Parse(nUDAgeTo.Value.ToString());
                recruitmentRequirement.CreatedDate = dt;
                recruitmentRequirement.Experience = tbxExperience.Text;
                recruitmentContext.CreateRecruitmentRequirement(recruitmentRequirement);
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadData()
        {
            //Department
            departmentContext = new DepartmentContext();
            cbxDepartment.DisplayMember = "DepartmentName";
            cbxDepartment.ValueMember = "Id";
            cbxDepartment.DataSource = departmentContext.GetAllDepartments();
            //Education
            educationLevelListContext =new EducationLevelListContext();
            cbxEducationLevel.ValueMember= "Id";
            cbxEducationLevel.DisplayMember = "EducationLevelName";
            cbxEducationLevel.DataSource=educationLevelListContext.GetAllEducationLevelLists();
            //Position
            positionListContext =new PositionListContext();
            cbxPosition.ValueMember= "Id";
            cbxPosition.DisplayMember = "PositionName";
            cbxPosition.DataSource=positionListContext.GetAllPositionLists();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            try
            {
                recruitmentRequirement = new RecruitmentRequirement();
                recruitmentContext = new RecruitmentRequirementContext();
                DateTime dt;
                dt = DateTime.Now;

                recruitmentRequirement.Code = tbxCode.Text;
                recruitmentRequirement.Department = Int16.Parse(cbxDepartment.SelectedValue.ToString());
                recruitmentRequirement.JobPosition = Int16.Parse(cbxPosition.SelectedValue.ToString());
                recruitmentRequirement.EducationLevel = Int16.Parse(cbxEducationLevel.SelectedValue.ToString());
                recruitmentRequirement.AgeFrom = Int16.Parse(nUDAgeFrom.Value.ToString());
                recruitmentRequirement.AgeTo = Int16.Parse(nUDAgeTo.Value.ToString());
                recruitmentRequirement.CreatedDate = dt;
                recruitmentRequirement.Experience = tbxExperience.Text;
                recruitmentContext.CreateRecruitmentRequirement(recruitmentRequirement);
                MessageBox.Show("Thêm thành công");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

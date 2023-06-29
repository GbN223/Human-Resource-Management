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

namespace NguyenChiBao_WinApp.Pages.FillPage
{
    public partial class frmFillRecruitmentPlan : frmFillParent
    {
        RecruitmentRequirementContext requirementContext;
        RecruitmentRequirement recruitment;
        RecruitmentPlan plan;
        RecruitmentPlanContext planContext; 
        public frmFillRecruitmentPlan()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnSaveBack.Click += BtnSaveBack_Click;
            LoadData();
        }

        private void BtnSaveBack_Click(object? sender, EventArgs e)
        {
            try
            {
                plan = new RecruitmentPlan();
                planContext = new RecruitmentPlanContext();
                plan.Code = tbxCode.Text;
                plan.CreatedDate = DateTime.Now;
                plan.Requirement = (int)cbxRequire.SelectedValue;
                plan.Workplace = tbxWorkplace.Text;
                planContext.AddRecruitmentPlan(plan);
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
            try
            {



                requirementContext = new RecruitmentRequirementContext();
                cbxRequire.DisplayMember = "Code";
                cbxRequire.ValueMember = "Id";
                cbxRequire.DataSource = requirementContext.GetAllRecruitmentRequirements();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            try
            {
                plan=new RecruitmentPlan();
                planContext=new RecruitmentPlanContext();
                plan.Code = tbxCode.Text;
                plan.CreatedDate = DateTime.Now;
                plan.Requirement = (int)cbxRequire.SelectedValue;
                plan.Workplace = tbxWorkplace.Text;
                planContext.AddRecruitmentPlan(plan);
                MessageBox.Show("Thêm thành công");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox4_Click(object sender, EventArgs e)
        {

        }

        private void cbxRequire_SelectedValueChanged(object sender, EventArgs e)
        {
           

        }

        private void cbxRequire_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            int selectedValue = (int)comboBox.SelectedValue;
            int id = selectedValue;
                requirementContext = new RecruitmentRequirementContext();
                recruitment = new RecruitmentRequirement();
                recruitment = requirementContext.GetRecruitmentRequirementById(id);
                lblAgeFrom.Text = recruitment.AgeFrom.ToString();
                lblAgeTo.Text = recruitment.AgeTo.ToString();
                lblQuanity.Text = recruitment.Quantity.ToString();
                
            
        }
    }
}

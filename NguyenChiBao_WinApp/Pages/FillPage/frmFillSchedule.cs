using NguyenChiBao_WinApp.Contexts;
using NguyenChiBao_WinApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenChiBao_WinApp.Pages.FillPage
{
    public partial class frmFillSchedule : frmFillParent
    {
        Schedule schedule;
        ScheduleContext context;
        RecruitmentPlanContext planContext;
        PersonnalProfileContext Personalcontext = new PersonnalProfileContext();
        RecruitmentRequirementContext recruitmentRequirementContext = new RecruitmentRequirementContext();
        CandidateProfileContext candidateProfileContext = new CandidateProfileContext();
        RecruitmentPlan plan = new RecruitmentPlan();
        RecruitmentRequirementContext recruitmentRequirecontext = new RecruitmentRequirementContext();
        RecruitmentRequirement recruitment = new RecruitmentRequirement();
        RecruitmentPlanContext recruitmentPlanContext = new RecruitmentPlanContext();
        PositionListContext positionListContext = new PositionListContext();
        DepartmentContext DepartmentContext = new DepartmentContext();
        public frmFillSchedule()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            LoadData();
        }

        private void LoadData()
        {


            ////Candidate
            ///
            cbxCandidate.DisplayMember = "FullName";
            cbxCandidate.ValueMember = "Id";
            cbxCandidate.DataSource = candidateProfileContext.GetAllCandidateProfiles();


            //RecruitmentPlan
            planContext = new RecruitmentPlanContext();
            cbxRecruimentPlan.DisplayMember = "Code";
            cbxRecruimentPlan.ValueMember = "Id";
            cbxRecruimentPlan.DataSource = planContext.GetAllRecruitmentPlan();
            ////ResponsiblePerson
            cbxResponsblePerson.DisplayMember = "PersonalName";
            cbxResponsblePerson.ValueMember = "Id";
            cbxResponsblePerson.DataSource = Personalcontext.GetAllPersonalProfiles();
            //


        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            try
            {
                string result = "";
                if (cxResult.Checked)
                {
                    result = "Đạt";
                }
                schedule = new Schedule();
                schedule.Code = tbxCode.Text;
                schedule.Result = result;
                schedule.Status = cbxStatus.Text;
                schedule.ResponsiblePerson = (int)cbxResponsblePerson.SelectedValue;
                schedule.RecruitmentPlan = (int)cbxRecruimentPlan.SelectedValue;
                schedule.AppointmentDate = DateTime.Parse(cbxDate.Text);
                schedule.Feedback = tbxFeedback.Text;
                schedule.Candidate = (int)cbxCandidate.SelectedValue;
                CandidateProfileContext profileContext = new CandidateProfileContext();
                CandidateProfile candidateProfile = new CandidateProfile();
                candidateProfile = candidateProfileContext.GetCandidateProfileById((int)cbxCandidate.SelectedValue);
                context = new ScheduleContext();
                context.CreateSchedule(schedule);
                SendMail(schedule.Candidate,cbxDate.Text,lblDepartment.Text);
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void SendMail(int id,string date,string position)
        {
           CandidateProfile candidate= candidateProfileContext.GetCandidateProfileById(id);
            string mail = candidate.Email;
            try
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("baoathlean@gmail.com");
                mailMessage.To.Add(new MailAddress(mail));
                mailMessage.Subject = "Thông báo từ doanh nghiệp";

                // Đọc nội dung từ file HTML
                string htmlFilePath = "E:\\HKII_2023\\THNN\\AndroidApp\\NguyenChiBao_WinApp\\Template\\index.html";
                string htmlBody = File.ReadAllText(htmlFilePath);

                // Thay thế giá trị của position và date trong template HTML
                htmlBody = htmlBody.Replace("[POSITION]", date);
                htmlBody = htmlBody.Replace("[DATE]", position);

                // Tạo một AlternateView từ phiên bản HTML
                AlternateView alternateView = AlternateView.CreateAlternateViewFromString(htmlBody, null, "text/html");
                mailMessage.AlternateViews.Add(alternateView);

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("baoathlean@gmail.com", "jlaecjncgouxznwd");

                smtpClient.Send(mailMessage);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void cbxDate_Click(object sender, EventArgs e)
        {
            mcDate.Visible = true;
        }

        private void cbxRecruimentPlan_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cbxRecruimentPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            int id = (int)comboBox.SelectedValue;

            plan = recruitmentPlanContext.GetRecruitmentPlanId(id);
            recruitment = recruitmentRequirecontext.GetRecruitmentRequirementById(plan.Requirement);
            lblPosition.Text = positionListContext.GetPositionListById(recruitment.JobPosition).PositionName;
            lblDepartment.Text = DepartmentContext.GetDepartmentById(recruitment.Department).DepartmentName;
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblDepartment_Click(object sender, EventArgs e)
        {

        }

        private void mcDate_DateSelected_2(object sender, DateRangeEventArgs e)
        {
            cbxDate.Text = e.Start.ToShortDateString();
            cbxDate.Items.Add(e.Start.ToShortDateString());
            mcDate.Visible = false;
        }
    }
}

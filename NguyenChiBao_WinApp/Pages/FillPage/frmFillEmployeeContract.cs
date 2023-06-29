using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class frmFillEmployeeContract : frmFillParent
    {
        PersonnalProfileContext personnalProfileContext;

        EmploymentContractContext employmentContractContext;
        EmploymentContract employmentContract;
        DepartmentContext department;
        SalaryGradeContext salaryGrade;
        BonusContext bonusContext;
        AllowanceContext allowanceContext;
        AllowanceDetailsContext allowanceDetailsContext;
        SalaryGradeDetails gradeDetails;
        AllowanceDetails allowanceDetails;
        SalaryGradeDetailContext gradeDetail;
        public frmFillEmployeeContract()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            LoadData();
            dtSalary.Rows.Clear();
            dtSalary.Refresh();
            //float SumSalary = CalculateColumnSum(dtSalary);

        }

        private void LoadData()
        {
            department = new DepartmentContext();
            cbxDepartment.DisplayMember = "DepartmentName";
            cbxDepartment.ValueMember = "Id";
            cbxDepartment.DataSource = department.GetAllDepartments();

            List<string> options = new List<string>
            {
                "Có thời hạn",
                "Không thời hạn"
            };

            // Gán danh sách chuỗi vào ComboBox
            cbxContractType.Items.AddRange(options.ToArray());
            //
            float minSalary = 1490000;
            string formattedSalary = minSalary.ToString("#,##0");
            lblMinSalary.Text = formattedSalary;
            lblMinSalary.Enabled = false;
            //
            allowanceContext = new AllowanceContext();
            cbxAlllowance.DisplayMember = "AllowanceName";
            cbxAlllowance.ValueMember = "Id";
            cbxAlllowance.DataSource = allowanceContext.GetAllAllowance();
            //
            // Đầu tiên, thêm một mục trống vào ComboBox
            cbxSalaryGrade.Items.Insert(0, "");

            // Sau đó, đặt selectedIndex của ComboBox thành 0 để chọn mục trống làm giá trị đầu tiên
            cbxSalaryGrade.SelectedIndex = 0;
            salaryGrade = new SalaryGradeContext();
            cbxSalaryGrade.DisplayMember = "GradeName";
            cbxSalaryGrade.ValueMember = "Id";
            cbxSalaryGrade.DataSource = salaryGrade.GetAllSalaryGrades();
            //
            PersonnalProfileContext personnal = new PersonnalProfileContext();
            cbxEmployee.DisplayMember = "PersonalName";
            cbxEmployee.ValueMember = "Id";
            cbxEmployee.DataSource = personnal.GetAllPersonalProfiles();

        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            DateTime dateTimeStart = dtpStartDate.Value;
            DateTime dateTimeEnd = dtpStartDate.Value;

            if (cbxContractType.Text == "Không thời hạn")
            {
                dateTimeEnd = new DateTime(9999, 12, 31);


            }
            try
            {
                int EmployeeId = (int)cbxEmployee.SelectedValue;
                string formattedEnd = dateTimeEnd.ToString("MM/dd/yy");
                string formattedDate = dateTimeStart.ToString("MM/dd/yy");
                employmentContract = new EmploymentContract();
                employmentContractContext = new EmploymentContractContext();
                employmentContract.Employee = EmployeeId;
                employmentContract.CreatedDate = DateTime.Now;
                employmentContract.StartDate = DateTime.Parse(formattedDate);
                employmentContract.EndDate = DateTime.Parse(formattedEnd);
                employmentContract.Workplace = tbxDescription.Text;
                employmentContract.Code = tbxCode.Text;
                label1.Text = employmentContractContext.IsEmployeeContractCreated(EmployeeId, formattedDate).ToString();
                if (employmentContractContext.IsEmployeeContractCreated(EmployeeId, formattedDate) == true)
                {
                    MessageBox.Show("Hợp đồng chưa hết hạn! Nếu muốn thay đổi dữ liệu hãy cập nhật hợp đồng");
                }
                else
                {
                    int idContract = employmentContractContext.CreateEmployeeContract(employmentContract);

                    if (dtSalary.RowCount > 0 && idContract != null)
                    {
                        AddAllowancesContract(idContract);
                        AddSalaryGrade(idContract);
                    }
                    MessageBox.Show("Thêm thành công");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại" + ex.Message);
            }
        }

        private void cbxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            int selectedValue = (int)comboBox.SelectedValue;
            personnalProfileContext = new PersonnalProfileContext();

            cbxEmployee.DisplayMember = "PersonalName";
            cbxEmployee.ValueMember = "Id";
            cbxEmployee.DataSource = personnalProfileContext.GetEmployeebyDepartment(selectedValue);

        }

        private void cbxContractType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedValue = (string)comboBox.SelectedValue;
            if (selectedValue == "Không thời hạn")
            {
                dtpEndDate.Enabled = false;
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedIndex == 0 && comboBox.SelectedValue == null)
            {
                // Giá trị được chọn là mục trống
                // Thực hiện các thao tác cần thiết
            }
            else
            {
                // Giá trị được chọn không phải là mục trống
                int selectedValue = (int)comboBox.SelectedValue;
                // Thực hiện các thao tác khác
                salaryGrade = new SalaryGradeContext();
                SalaryGrade salary = new SalaryGrade();
                salary = salaryGrade.GetSalaryGradeById(selectedValue);
                AddSalaryBasic(selectedValue, salary.GradeName, (float)salary.Coefficient);
                lblSalaryContract.Text = CalculateColumnSum(dtSalary).ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int selectedValue = (int)cbxAlllowance.SelectedValue;
            allowanceContext = new AllowanceContext();
            Allowance allowance = new Allowance();
            allowance = allowanceContext.GetAllowanceById(selectedValue);
            AddAllowance(selectedValue, allowance.AllowanceName, (float)allowance.AllowanceAmount);
            lblSumAllowance.Text = CalculateAllowance().ToString("#,##0");
            lblSalaryContract.Text = CalculateColumnSum(dtSalary).ToString("#,##0");
        }
        private void AddAllowance(int id, string name, float coei)
        {
            DataGridViewColumn nameColumn = dtSalary.Columns["Parameter"];
            if (nameColumn != null)
            {
                int columnIndex = nameColumn.Index;
                dtSalary.Rows.Insert(0, name);
                dtSalary.Rows[0].Cells[columnIndex].Value = name;
            }
            // Thêm giá trị vào cột "id"
            DataGridViewColumn idColumn = dtSalary.Columns["Id"];
            if (idColumn != null)
            {
                int columnIndex = idColumn.Index;
                dtSalary.Rows[0].Cells[columnIndex].Value = id;
            }
            // Thêm giá trị vào cột "Sum"
            DataGridViewColumn sumColumn = dtSalary.Columns["Sum"];
            if (sumColumn != null)
            {
                int columnIndex = sumColumn.Index;
                dtSalary.Rows[0].Cells[columnIndex].Value = coei;
            }
        }
        private void AddSalaryBasic(int id, string name, float coei)
        {
            DataGridViewColumn nameColumn = dtSalary.Columns["Parameter"];
            if (nameColumn != null)
            {
                int columnIndex = nameColumn.Index;
                dtSalary.Rows.Insert(0, name);
                dtSalary.Rows[0].Cells[columnIndex].Value = name;
            }
            // Thêm giá trị vào cột "id"
            DataGridViewColumn idColumn = dtSalary.Columns["Id"];
            if (idColumn != null)
            {
                int columnIndex = idColumn.Index;
                dtSalary.Rows[0].Cells[columnIndex].Value = id;
            }
            // Thêm giá trị vào cột "Sum"
            DataGridViewColumn coeiColumn = dtSalary.Columns["Coei"];
            if (coeiColumn != null)
            {
                int columnIndex = coeiColumn.Index;
                dtSalary.Rows[0].Cells[columnIndex].Value = coei;
            }
            DataGridViewColumn sumColumn = dtSalary.Columns["Sum"];
            if (sumColumn != null)
            {
                int columnIndex = sumColumn.Index;
                dtSalary.Rows[0].Cells[columnIndex].Value = coei * 1490000;
            }

        }
        private void dtSalary_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //lblSumAllowance.Text = CalculateColumnSum(dtSalary).ToString("#,##0");
        }
        private float CalculateAllowance()
        {
            float sum = 0;

            // Lặp qua từng hàng trong DataGridView
            foreach (DataGridViewRow row in dtSalary.Rows)
            {
                // Kiểm tra giá trị trong cột "Name" có chứa chữ "Phụ cấp" hay không
                if (row.Cells["Parameter"].Value != null && row.Cells["Parameter"].Value.ToString().Contains("Phụ cấp"))
                {
                    // Lấy giá trị từ cột "Value" và cộng vào biến sum
                    if (float.TryParse(row.Cells["Sum"].Value.ToString(), out float value))
                    {
                        sum += value;
                    }
                }
            }
            return sum;
        }
        private float CalculateColumnSum(DataGridView dataGridView)
        {
            float sum = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[2].Value != null && float.TryParse(row.Cells[2].Value.ToString(), out float cellValue))
                {
                    sum += cellValue;
                }
            }

            return sum;
        }
        private void AddAllowancesContract(int Employee)
        {
            allowanceDetails = new AllowanceDetails();
            List<AllowanceDetails> details = new List<AllowanceDetails>();
            allowanceDetailsContext = new AllowanceDetailsContext();
            for (int i = 0; i < GetSumValuesByColumnName(dtSalary, "Phụ cấp").Count; i++)
            {
                int Id = GetSumValuesByColumnName(dtSalary, "Phụ cấp")[i];
                allowanceDetailsContext.AddAllowance(Id, Employee, DateTime.Now);
            }
            //foreach(AllowanceDetails details1 in details)
            //{
            //    allowanceDetailsContext.CreateAllowanceDetails(details1);
            //}

        }

        private void AddSalaryGrade(int Employee)
        {
            gradeDetail = new SalaryGradeDetailContext();
            gradeDetails = new SalaryGradeDetails();
            int id = 0;
            int count = GetSumValuesByColumnName(dtSalary, "Lương").Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    id = GetSumValuesByColumnName(dtSalary, "Lương")[i];
                    gradeDetails.EmployeeContract = Employee;
                    gradeDetails.SalaryGrade = id;
                    gradeDetails.EffectiveDate = DateTime.Now;
                    gradeDetail.AddSalaryGradeDetail(gradeDetails);

                }

            }


        }
        public List<int> GetSumValuesByColumnName(DataGridView dataGridView, string searchText)
        {
            List<int> sumValues = new List<int>();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["Parameter"].Value != null && row.Cells["Parameter"].Value.ToString().Contains(searchText))
                {

                    int value = Convert.ToInt16(row.Cells[3].Value);


                    sumValues.Add(value);

                }
            }

            return sumValues;
        }

        private void dtSalary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dtSalary.Rows[e.RowIndex];
                dtSalary.Rows.Remove(selectedRow);
                lblSalaryContract.Text = CalculateColumnSum(dtSalary).ToString();
            }
        }
    }
}

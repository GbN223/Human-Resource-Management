using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Models
{
    [Table("SalaryGradeDetails")]
    internal class SalaryGradeDetails
    {
        private int id;
        private int salaryGrade;
        private int employeeContract;
        private DateTime effectiveDate;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int SalaryGrade
        {
            get { return salaryGrade; }
            set { salaryGrade = value; }
        }

        public int EmployeeContract
        {
            get { return employeeContract; }
            set { employeeContract = value; }
        }

        public DateTime EffectiveDate
        {
            get { return effectiveDate; }
            set { effectiveDate = value; }
        }
        public SalaryGradeDetails() { }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Models
{
    [Table("SalaryGrade")]
    internal class SalaryGrade
    {
        private int id;
        private string code;
        private string gradeName;
        private DateTime effectiveDate;
        private decimal coefficient;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public string GradeName
        {
            get { return gradeName; }
            set { gradeName = value; }
        }

        public DateTime EffectiveDate
        {
            get { return effectiveDate; }
            set { effectiveDate = value; }
        }

        public decimal Coefficient
        {
            get { return coefficient; }
            set { coefficient = value; }
        }
        public SalaryGrade() { }
    }
}

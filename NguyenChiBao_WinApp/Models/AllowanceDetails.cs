using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Models
{
    [Table("AllowanceDetails")]
    internal class AllowanceDetails
    {
        
        private int id;
        private int allowance;
        private int employeeContract;
        private DateTime effectiveDate;
        public int Id
        {
            get { return id; }
            private set { id = value; }
        }
        public int Allowance
        {
            get { return allowance; }
            set { allowance = value; }
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
        public AllowanceDetails() { }
    }
}

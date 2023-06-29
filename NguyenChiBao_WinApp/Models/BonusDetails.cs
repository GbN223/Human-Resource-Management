using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Models
{
    [Table("BonusDetails")]
    internal class BonusDetails
    {
        private int idBonus;
        private int employeeContract;
        private DateTime effectiveDate;

        public int IdBonus
        {
            get { return idBonus; }
            set { idBonus = value; }
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
        public BonusDetails() { }
    }
}

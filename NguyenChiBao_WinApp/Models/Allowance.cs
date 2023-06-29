using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Models
{
    [Table("Allowance")]
    internal class Allowance
    {
        private int id;
        private string code;
        private string allowanceName;
        private decimal allowanceAmount;

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

        public string AllowanceName
        {
            get { return allowanceName; }
            set { allowanceName = value; }
        }

        public decimal AllowanceAmount
        {
            get { return allowanceAmount; }
            set { allowanceAmount = value; }
        }
        public Allowance() { }
    }
}

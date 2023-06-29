using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Models
{
    [Table("Bonus")]
    internal class Bonus
    {
        private int id;
        private string code;
        private string bonusName;
        private decimal bonusAmount;

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

        public string BonusName
        {
            get { return bonusName; }
            set { bonusName = value; }
        }

        public decimal BonusAmount
        {
            get { return bonusAmount; }
            set { bonusAmount = value; }
        }
        public Bonus() { }
    }
}

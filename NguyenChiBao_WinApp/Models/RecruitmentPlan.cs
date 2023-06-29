using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Models
{
    [Table("RecruitmentPlan")]
    internal class RecruitmentPlan
    {
        private int id;
        private string code;
        private DateTime createdDate;
        private string workplace;
        private int requirement;
        public RecruitmentPlan() {
           
          
        }
        public RecruitmentPlan(int Id, string Code, DateTime CreatedDate, string Workplace, int Requirement)
        {
            id = Id;
            code = Code;
            createdDate = CreatedDate;
            workplace = Workplace;
            requirement = Requirement;
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        public string Workplace
        {
            get { return workplace; }
            set { workplace = value; }
        }

        public int Requirement
        {
            get { return requirement; }
            set { requirement = value; }
        }
    }
}

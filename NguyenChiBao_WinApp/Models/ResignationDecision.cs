using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Models
{
    [Table("ResignationDecision")]
    internal class ResignationDecision
    {
        private int id;
        private string code;
        private DateTime createdDate;
        private DateTime effectiveDate;
        private string descriptionDecision;
        private int employee;
        private string reason;

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

        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        public DateTime EffectiveDate
        {
            get { return effectiveDate; }
            set { effectiveDate = value; }
        }

        public string DescriptionDecision
        {
            get { return descriptionDecision; }
            set { descriptionDecision = value; }
        }

        public int Employee
        {
            get { return employee; }
            set { employee = value; }
        }

        public string Reason
        {
            get { return reason; }
            set { reason = value; }
        }
        public ResignationDecision() { }
    }
}

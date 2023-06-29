using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Models
{
    [Table("EmploymentContract")]
    internal class EmploymentContract
    {
        private int id;
        private string code;
        private DateTime createdDate;
        private string contractType;
        private int employee;
        private DateTime startDate;
        private DateTime endDate;
        private string workplace;

        public int Id
        {
            get { return id; }
            private set { id = value; }
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

        public string ContractType
        {
            get { return contractType; }
            set { contractType = value; }
        }

        public int Employee
        {
            get { return employee; }
            set { employee = value; }
        }
            
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public string Workplace
        {
            get { return workplace; }
            set { workplace = value; }
        }
        public EmploymentContract() { }
       
    }
}

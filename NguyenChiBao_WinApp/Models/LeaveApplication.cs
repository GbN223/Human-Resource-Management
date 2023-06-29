using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Models
{
    internal class LeaveApplication
    {
        private int id;
        private string code;
        private DateTime createdDate;
        private DateTime startDate;
        private DateTime endDate;
        private int result;
        private int employee;

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

        public int Result
        {
            get { return result; }
            set { result = value; }
        }

        public int Employee
        {
            get { return employee; }
            set { employee = value; }
        }
        public LeaveApplication() { }
    }
}

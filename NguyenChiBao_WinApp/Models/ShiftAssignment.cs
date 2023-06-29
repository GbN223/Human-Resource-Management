using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Models
{
    internal class ShiftAssignment
    {
        private int id;
        private string code;
        private DateTime createdDate;
        private TimeSpan clockInTime;
        private DateTime startDate;
        private DateTime endDate;

        public int Id { get { return id; } set { id = value; } }
        public string Code { get { return code; } set { code = value; } }
        public DateTime CreatedDate { get { return createdDate; } set { createdDate = value; } }
        public TimeSpan ClockInTime { get { return clockInTime; } set { clockInTime = value; } }
        public DateTime StartDate { get { return startDate; } set { startDate = value; } }
        public DateTime EndDate { get { return endDate; } set { endDate = value; } }

        public ShiftAssignment() { }
    }
}

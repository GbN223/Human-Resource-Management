using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Models
{
    internal class TimeKeeping
    {
        private int id;
        private DateTime timekeeping;
        private int employee;
        private int timekeepingLocation;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime Timekeeping
        {
            get { return timekeeping; }
            set { timekeeping = value; }
        }

        public int Employee
        {
            get { return employee; }
            set { employee = value; }
        }

        public int TimekeepingLocation
        {
            get { return timekeepingLocation; }
            set { timekeepingLocation = value; }
        }
        public TimeKeeping() { }
    }
}

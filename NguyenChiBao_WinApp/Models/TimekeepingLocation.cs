using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Models
{
    internal class TimekeepingLocation
    {
        private int id;
        private string code;
        private string nameLocation;
        private decimal longitude;
        private decimal latitude;

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

        public string NameLocation
        {
            get { return nameLocation; }
            set { nameLocation = value; }
        }

        public decimal Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        public decimal Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }
        public TimekeepingLocation() { }
    }
}

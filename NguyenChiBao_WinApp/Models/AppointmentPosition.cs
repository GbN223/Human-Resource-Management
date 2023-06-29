using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Models
{
    [Table("AppointmentPosition")]
    internal class AppointmentPosition
    {
        private int id;
        private int personal;
        private int position;
        private DateTime createdDate;
        private DateTime effectiveDate;

        public int Id { get { return id; }}
        public int Personal
        {
            get { return personal; }
            set { personal = value; }
        }

        public int Position
        {
            get { return position; }
            set { position = value; }
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

        public AppointmentPosition()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Models
{
    [Table("TransferDepartment")]

    internal class TransferDepartment
    {
        private int id;
        private int personal;
        private int department;
        private DateTime createdDate;
        private DateTime effectiveDate;

        public int Id { get {return id; } set {id=value; } }
        public int Personal { get { return personal; } set {personal=value; }  }
        public int Department { get { return department; } set { department = value; } }
        public DateTime CreatedDate { get { return createdDate; } set { createdDate = value; } }
        public DateTime EffectiveDate { get { return effectiveDate; } set { effectiveDate = value; } }

        public TransferDepartment()
        {
            
        }
    }
}

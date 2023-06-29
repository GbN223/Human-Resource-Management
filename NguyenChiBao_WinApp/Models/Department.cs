using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Models
{
    [Table("Department")]
    internal class Department
    {
        private int id;
        private string code;
        private string name;

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

        public string DepartmentName
        {
            get { return name; }
            set { name = value; }
        }
        public Department() { }
        public Department(int id, string code, string name)
        {
            Id = id;
            Code = code;
            DepartmentName = name;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Models
{
    [Table("EducationLevelList")]
    internal class EducationLevelList
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

        public string EducationLevelName
        {
            get { return name; }
            set { name = value; }
        }
        public EducationLevelList()
        {

        }
        public EducationLevelList(int id, string code, string name)
        {
            Id = id;
            Code = code;
            EducationLevelName = name;
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Models
{
    [Table("PositionList")]
    internal class PositionList
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

        public string PositionName
        {
            get { return name; }
            set { name = value; }
        }

        public PositionList(int id, string code, string name)
        {
            Id = id;
            Code = code;
            PositionName = name;
        }
        public PositionList() { }
    }
}

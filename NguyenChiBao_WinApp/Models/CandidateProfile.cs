using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Models
{
    [Table("CandidateProfile")]
    internal class CandidateProfile
    {
        private int id;
        private string code;
        private DateTime createdDate;
        private string fullName;
        private string phone;
        private string email;
        private string address;
        private string gender;
        private DateTime birthDate;


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

     
        public string Gender { get { return gender; }set { gender = value; } }
        public DateTime BirthDate { get { return birthDate; } set { birthDate = value; } } 
        public string Phone { get { return phone; }set{phone = value;}}
        public string Email { get { return email; } set { email = value; } }
        public string Address { get { return address; }set{address = value;} }
        public string FullName { get { return fullName; }
            set
            {
                fullName = value;
            } }
        public CandidateProfile() { }
        

    }
}

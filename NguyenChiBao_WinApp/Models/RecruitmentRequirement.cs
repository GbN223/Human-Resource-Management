using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Models
{
    [Table("RecruitmentRequirement")]
    internal class RecruitmentRequirement
    {
        private int id;
        private string code;
        private DateTime createdDate;
        private int department;
        private int jobPosition;
        private int educationLevel;
        private int quantity;
        private string gender;
        private int ageFrom;
        private int ageTo;
        private string experience;
        public RecruitmentRequirement() { }
        
        public int ID
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

        public int Department
        {
            get { return department; }
            set { department = value; }
        }

        public int JobPosition
        {
            get { return jobPosition; }
            set { jobPosition = value; }
        }

        public int EducationLevel
        {
            get { return educationLevel; }
            set { educationLevel = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int AgeFrom
        {
            get { return ageFrom; }
            set { ageFrom = value; }
        }

        public int AgeTo
        {
            get { return ageTo; }
            set { ageTo = value; }
        }

        public string Experience
        {
            get { return experience; }
            set { experience = value; }
        }
    }
}

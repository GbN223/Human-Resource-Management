using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Models
{
    [Table("PersonalProfile")]
    internal class PersonalProfile
    {
        private int id;
        private string code;
        private string personalName;
        private DateTime dateBirth;
        private DateTime dateEmployment;
        private string gender;
        private string identificationCard;
        private string nationality;
        private string ethnicity;
        private string religion;
        private string permanentAddress;
        private string temporaryAddress;
        private string hometown;
        private string email;
        private string phoneNumber;
        private string image;
        private int educationalLevel;
        private string taxIdentificationNumber;
        public PersonalProfile() { }
        
        public int Id
        {
            get { return id; }
            private set { id = value; }
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public string PersonalName
        {
            get { return personalName; }
            set { personalName = value; }
        }

        public DateTime DateBirth
        {
            get { return dateBirth; }
            set { dateBirth = value; }
        }

        public DateTime DateEmployment
        {
            get { return dateEmployment; }
            set { dateEmployment = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string IdentificationCard
        {
            get { return identificationCard; }
            set { identificationCard = value; }
        }

        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }

        public string Ethnicity
        {
            get { return ethnicity; }
            set { ethnicity = value; }
        }

        public string Religion
        {
            get { return religion; }
            set { religion = value; }
        }

        public string PermanentAddress
        {
            get { return permanentAddress; }
            set { permanentAddress = value; }
        }

        public string TemporaryAddress
        {
            get { return temporaryAddress; }
            set { temporaryAddress = value; }
        }

        public string Hometown
        {
            get { return hometown; }
            set { hometown = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }


        public int EducationalLevel
        {
            get { return educationalLevel; }
            set { educationalLevel = value; }
        }

        public string TaxIdentificationNumber
        {
            get { return taxIdentificationNumber; }
            set { taxIdentificationNumber = value; }
        }
        public string Image { get{ return image; } set{ image=value;} }
    }

}

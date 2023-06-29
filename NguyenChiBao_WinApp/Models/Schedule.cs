using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenChiBao_WinApp.Models
{
    [Table("InterviewSchedule")]
    internal class Schedule
    {
      
        private int id;
        private string code;
        private DateTime appointmentDate;
        private int responsiblePerson;
        private int candidate;
        private int recruitmentPlan;
        private string result;
        private string status;
        private string feedback;

        public Schedule() { }
        
        public int ID { get { return id; } set { id = value; } }
        public string Code { get { return code; } set { value = Code; } }
        public DateTime AppointmentDate { get { return appointmentDate; } set { appointmentDate = value; } }
        public int ResponsiblePerson { get { return responsiblePerson; } set { responsiblePerson = value; } }
        public int Candidate { get { return candidate; } set { candidate = value; } }
        public int RecruitmentPlan { get { return recruitmentPlan; } set { recruitmentPlan = value; } }
        public string Result { get { return result; } set { result = value; } }
        public string Status { get { return status; } set { status = value; } }
        public string Feedback { get {  return feedback; } set {  feedback = value; } }
    }
}

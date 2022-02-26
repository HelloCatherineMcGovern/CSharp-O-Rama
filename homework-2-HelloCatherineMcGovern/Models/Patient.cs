using System;
using homework2DbContext.Models;

namespace homework2patient.Models
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public DateTime AdmitDate { get; set; } // Date & time 
        public string HadExam { get; set; }
    }

}

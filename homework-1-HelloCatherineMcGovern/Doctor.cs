using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using homeworkpatient.Models;

namespace homeworkdoctor.Models
{
    public class Doctor

    {
        //Let make a doctor!
        public string firstName { get; set; }
        public string lastName { get; set; }

        //Let's make a list of patients
        //But tis no ordinary list - tis a list of patient objects!
        public List<Patient> patientList { get; set; }

        //Now let's print all that out!

        public override string ToString()
        {
            //Let's transform the list of patients in to a string to print to the console
            var myPatientListString = new StringBuilder();
            int x = 0;
            //loop through all the patients in each doctor's patient list.
            foreach (Patient element in patientList)
            {
                x++;
                //format list and make it look pretty
                myPatientListString.Append($"-{element.firstName} {element.lastName} \n");
            }
            return "Doctor " + firstName + " " + lastName + " has the following " + x + " patients:\n" + myPatientListString;

        }

    }
}
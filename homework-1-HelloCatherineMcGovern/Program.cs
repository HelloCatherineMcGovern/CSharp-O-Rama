using System;
using System.Collections;
using System.Collections.Generic;
using homeworkpatient.Models;
using homeworkdoctor.Models;

namespace homework_1_HelloCatherineMcGovern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Let's make patients galore!!
            Patient patientOne = new Patient { firstName = "Molly", lastName = "McGovern" };
            Patient patientTwo = new Patient { firstName = "Bernie", lastName = "McDuff" };
            Patient patientThree = new Patient { firstName = "Angela", lastName = "Lansbury" };
            Patient patientFour = new Patient { firstName = "Toby", lastName = "McBride" };
            Patient patientFive = new Patient { firstName = "Mavis", lastName = "Banks" };
            Patient patientSix = new Patient { firstName = "Murray", lastName = "Smith" };
            Patient patientSeven = new Patient { firstName = "Jerry", lastName = "Smith" };
            Patient patientEight = new Patient { firstName = "Rick", lastName = "Sanchez" };
            Patient patientNine = new Patient { firstName = "Danny", lastName = "Dinosaur" };
            Patient patientTen = new Patient { firstName = "Trent", lastName = "Trout" };


            //Let's make some doctors!!!
            Doctor doctorOne = new Doctor { firstName = "Ethel", lastName = "Merman", patientList = new List<Patient> { patientOne, patientTwo } };
            //initialize list o' doctors that I'll loop through at the end
            List<Doctor> myDoctorList = new List<Doctor>();
            //add first doctor to the final doctor list
            myDoctorList.Add(doctorOne);

            //Second Doctor + Patient List!!!
            Doctor doctorTwo = new Doctor { firstName = "Sweeney", lastName = "Todd", patientList = new List<Patient> { patientThree, patientFour, patientFive } };
            //add second doctor to the final doctor list
            myDoctorList.Add(doctorTwo);

            //Third Doctor + Patient List!!!
            Doctor doctorThree = new Doctor { firstName = "Beth", lastName = "Smith", patientList = new List<Patient> { patientSix, patientSeven } };
            //add third doctor to the final doctor list
            myDoctorList.Add(doctorThree);

            //Fourth Doctor + Patient List!!!
            Doctor doctorFour = new Doctor { firstName = "Morty", lastName = "Smith", patientList = new List<Patient> { patientEight, patientNine, patientTen } };
            //add fourth doctor to the final doctor list
            myDoctorList.Add(doctorFour);

            //Using a foreach loop we loop through the doctor list and show everyone!!
            foreach (var element in myDoctorList)
            {
                Console.WriteLine($"{element}");
            }


        }
    }
}
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using homework2DbContext.Models;
using homework2patient.Models;
using System.Linq;

namespace homework_2_HelloCatherineMcGovern
{
    class Program
    {
        //SEED DATABASE

        static void Seed()
        {
            //SEED THAT DATABASE IF NEEDED
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();
                //code below found here: https://docs.microsoft.com/en-us/ef/core/modeling/data-seeding
                var testBlog = db.Patients.FirstOrDefault();
                if (testBlog == null) //test to see if there is anything in the database
                {
                    Patient patientOne = new Patient
                    {
                        FirstName = "Roxie",
                        LastName = "Hart",
                        Age = 34,
                        Gender = "F",
                        AdmitDate = new DateTime(1924, 5, 28),
                        HadExam = "Y"
                    };
                    Patient patientTwo = new Patient
                    {
                        FirstName = "Grace",
                        LastName = "Bertrand",
                        Age = 24,
                        Gender = "F",
                        AdmitDate = new DateTime(1939, 1, 15),
                        HadExam = "Y"
                    };
                    Patient patientThree = new Patient
                    {
                        FirstName = "Harold",
                        LastName = "Hill",
                        Age = 52,
                        Gender = "M",
                        AdmitDate = new DateTime(1924, 7, 1),
                        HadExam = "N"
                    };
                    Patient patientFour = new Patient
                    {
                        FirstName = "Herman",
                        LastName = "Dietrich",
                        Age = 47,
                        Gender = "M",
                        AdmitDate = new DateTime(1936, 9, 12),
                        HadExam = "Y"
                    };
                    db.Add(patientOne);
                    db.Add(patientTwo);
                    db.Add(patientThree);
                    db.Add(patientFour);

                    db.SaveChanges();
                }
            }


        }

        //ADD FUNCTION
        //ADD FUNCTION
        //ADD FUNCTION
        static void Add()
        {
            Console.WriteLine("Let's add a patient to our database");
            //ADD FIRST NAME
            Console.WriteLine("What is the patient's first name");
            string newPatientFirstName = Console.ReadLine();
            //ADD LAST NAME
            Console.WriteLine("What is the patient's last name");
            string newPatientLastName = Console.ReadLine();
            //ADD AGE
            Console.WriteLine("What is the patient's age");
            int newPatientAge = Convert.ToInt32(Console.ReadLine());
            //ADD GENDER
            Console.WriteLine("What is the patient's gender");
            string newPatientGender = Console.ReadLine();
            //ADD ADMIT DATE
            Console.WriteLine("What is the patient's Admit Date?");
            Console.WriteLine("Please use format: YEAR, MONTH, DAY");
            string thisPatientAdmitDate = Console.ReadLine();
            DateTime newPatientAdmitDate = DateTime.Parse(thisPatientAdmitDate);
            //ADD EXAM STATUS
            Console.WriteLine("What is the patient's Exam Status");
            string newPatientExamStatus = Console.ReadLine();
            //CREATE THE NEW PATIENT WITH THE NEW INFO
            Patient patientNew = new Patient
            {
                FirstName = newPatientFirstName,
                LastName = newPatientLastName,
                Age = newPatientAge,
                Gender = newPatientGender,
                AdmitDate = newPatientAdmitDate,
                HadExam = newPatientExamStatus,
            };
            //Save patient to the database
            using (var db = new AppDbContext())
            {
                db.Add(patientNew);
                db.SaveChanges();
            }

        }

        //READ FUNCTION
        //READ FUNCTION
        //READ FUNCTION
        static void List()
        {
            using (var db = new AppDbContext())
            {
                //Use foreach loop to loop through patient in the database
                int listCount = 0;
                foreach (Patient p in db.Patients)
                {
                    listCount++;
                    Console.WriteLine("---------------------");
                    Console.WriteLine($"{listCount}: {p.FirstName} {p.LastName}\nAge: {p.Age} \nAdmit Date:{p.AdmitDate.ToShortDateString()} \nHad Exam: {p.HadExam} ");
                }
            }
        }

        static void Remove()
        {
            //Let's prompt the user for the name of the patient
            Console.WriteLine("Find the patient you want to remove using the last name. Enter it:");
            using (var db = new AppDbContext())
            {
                string patientToRemove = Console.ReadLine().ToLower();
                //Search through database for the patient
                var selectPatient = (from p in db.Patients
                                     where p.LastName.ToLower() == patientToRemove
                                     select p).First<Patient>();

                //Let's show the audience the patient record of the patient to be removed
                Console.WriteLine($"{selectPatient.PatientID} - {selectPatient.FirstName} {selectPatient.LastName},\n Age: {selectPatient.Age} \nAdmit Date:{selectPatient.AdmitDate.ToShortDateString()} \nHad E.xam: {selectPatient.HadExam} ");
                Console.WriteLine("Is this the patient you want to remove, type Y or N?");
                string removeAnswer = Console.ReadLine().ToLower();
                if (removeAnswer == "y")
                {
                    db.Remove(selectPatient);//Remove patient 
                    db.SaveChanges();  //Save changes in database   
                }

            }
        }
        //UPDATE FUNCTION
        //UPDATE FUNCTION
        //UPDATE FUNCTION
        static void Update()
        {
            //prompt user for patient last name
            Console.WriteLine("Find the patient using the last name. Enter it:");
            using (var db = new AppDbContext())
            {
                string patientToUpdate = Console.ReadLine().ToLower();
                //use patient last name to find record
                var selectPatient = (from p in db.Patients
                                     where p.LastName.ToLower() == patientToUpdate.ToLower()
                                     select p).First<Patient>();

                //Let's show the audience the patient record

                Console.WriteLine($"{selectPatient.PatientID} - {selectPatient.FirstName} {selectPatient.LastName},\n Age: {selectPatient.Age} \nAdmit Date:{selectPatient.AdmitDate} \nHad Exam: {selectPatient.HadExam} ");
                Console.WriteLine("Do you want to change the patient's \n1: First Name | 2:Last Name | 3: Age | 4:Gender | 5: Admit Date | 6: Had Exam");
                int switchName = Convert.ToInt32(Console.ReadLine());

                //use switch operation to select property to update
                switch (switchName)
                {
                    case 1: //UPDATE FIRST NAME
                        Console.WriteLine("Enter the new first name");
                        string newPatientFirstName = Console.ReadLine();
                        selectPatient.FirstName = newPatientFirstName;
                        break;
                    case 2: //UPDATE LAST NAME
                        Console.WriteLine("Enter the new last name");
                        string newPatientLastName = Console.ReadLine();
                        selectPatient.LastName = newPatientLastName;
                        break;
                    case 3: //Update Age
                        Console.WriteLine("Update Patient's Age");
                        int newPatientAge = Convert.ToInt32(Console.ReadLine());
                        selectPatient.Age = newPatientAge;
                        break;
                    case 4: //Change Gender
                        Console.WriteLine("Update Patient's Gender");
                        string newPatientGender = Console.ReadLine();
                        selectPatient.Gender = newPatientGender;
                        break;
                    case 5: //Change Admit date
                        Console.WriteLine("Update Patient's Admit Date");
                        string newPatientAdmitDate = Console.ReadLine();
                        DateTime thisAdmitDate = DateTime.Parse(newPatientAdmitDate);
                        selectPatient.AdmitDate = thisAdmitDate;
                        break;

                    case 6: //Change had exam status
                        Console.WriteLine("Update Patient's exam status");
                        string newPatientExamStatus = Console.ReadLine();
                        selectPatient.HadExam = newPatientExamStatus;
                        break;
                }

                db.SaveChanges();
                Console.WriteLine("The patient has now been updated");
                Console.WriteLine($"{selectPatient.PatientID} - {selectPatient.FirstName} {selectPatient.LastName},\n Age: {selectPatient.Age} \nAdmit Date:{selectPatient.AdmitDate} \nHad Exam: {selectPatient.HadExam} ");
            }

        }
        static void Main(string[] args)
        {
            Seed();

            Console.Write("-----------------------------------------");
            int choice = -1;
            while (choice != 0)
            {
                Console.Write("\nPlease make a selection: ");
                Console.Write("\n1: Read List 2: Update Patient 3: Remove Patient 4: Add Patient");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.Write("\nPlease make a selection: ");
                        break;
                    case 1:

                        //List
                        List();

                        break;
                    case 2:
                        Update();
                        break;
                    case 3:
                        Remove();
                        break;
                    case 4:
                        Add();
                        break;
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Krisprojnew;

namespace Krisprojnew.Codes
{

        internal class Person
        {
            private string? _firstName;

            private string? _lastName;
            public string BirthDateInDanishFormat { get; set; }
            public int Age { get; set; }
            public double TimeSpanInTotalDays { get; set; }

            public int TelephonNr { get; init; }

            public Person(string firstName, string lastName, DateTime birthDate)
            {
                _firstName = firstName;
                _lastName = lastName;
                TelephonNr = 12345678;
                BirthDateInDanishFormat = birthDate.ToString("dd-MM-yyyy");
                Age = DateTime.Now.Year - birthDate.Year;
                TimeSpan ts = DateTime.Now - birthDate;

            //int ss;
            //bool pass = int.TryParse("16A", out ss);
            //if (pass)
            //{
            //    Console.WriteLine("Does not match!");
            //}

            //int tstd = Convert.ToInt16(TimeSpanInTotalDays);
            //Console.WriteLine("Converted to int " + tstd);

            //object dblboxed = TimeSpanInTotalDays;
            ////Her bliver den pakket ud. 
            ////Hvis man ikke ved hvilken type den er pakket ind som, så kan man bruge TryCatch
            //// til at finde ud af hvilken type det er. 
            //double unboxed = (double)dblboxed;



            }

            public Person()
            {
                _firstName = "Kasper";
                _lastName = "Jensen";
            }

            public string? GetFullName()
            {
                return $"{_firstName} {_lastName}";
            }
        }
    }
//Object type er værdi i en kasse. 



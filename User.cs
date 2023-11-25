using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using hoteleria.Dto;
using Cassandra;

namespace hoteleria.Entity
{
    internal class User
    {
        public string email { get; set; }
        public string employeeNumber { get; set; }
        public String lastName { get; set; }
        public String firstName { get; set; }
        public string userType { get; set; }

        public LocalDate birthdate { get; set; }

        public string street { get; set; }
        public string neighborhood { get; set; }
        public int number { get; set; }
        public string tel1 { get; set; }
        public string tel2 { get; set; }

        public string userR { get; set; }

        public DateTime datetimeR { get; set; }
        public Boolean status { get; set; }
        public Boolean statusPass { get; set; }
        public string currentps { get; set; }
        public string past { get; set; }
        public string past2 { get; set; }

        public string temp { get; set; }
        public int intentosInicio { get; set; }


        public User()
        {
        }

        public bool ValidacionCorreo()
        {

            // Define a regular expression for validating email addresses
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,}$";

            // Create a Regex object
            Regex regex = new Regex(pattern);

            // Use the Regex.IsMatch method to check if the email is valid
            return regex.IsMatch(email);

        }


        public bool ValiacionPassword()
        {


            // Define a regular expression for validating passwords
            string pattern = @"^(?=.[a-z])(?=.[A-Z])(?=.\d)(?=.[^\da-zA-Z]).{8,}$";

            // Create a Regex object
            Regex regex = new Regex(pattern);

            // Use the Regex.IsMatch method to check if the password is valid
            return regex.IsMatch(currentps);


        }






    }



}
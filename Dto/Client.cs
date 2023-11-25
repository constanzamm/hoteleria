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
using Cassandra;
using hoteleria.Dto;

namespace hoteleria.Dto
{
    internal class Cliente
    {
        public String emailCLI { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String street { get; set; }
        public String neighborhood { get; set; }
        public int number { get; set; }
        public String rfc { get; set; }
        public String tel1 { get; set; }
        public String tel2 { get; set; }
        public String reference { get; set; }
        public String civilStatus { get; set; }
        public LocalDate birthdateCLI { get; set; }
        public String userR { get; set; }
        public DateTime dateTimeR { get; set; }
        public bool ValidacionCorreo()
        {

            // Define a regular expression for validating email addresses
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Create a Regex object
            Regex regex = new Regex(pattern);

            // Use the Regex.IsMatch method to check if the email is valid
            return regex.IsMatch(emailCLI);

        }

    }



}

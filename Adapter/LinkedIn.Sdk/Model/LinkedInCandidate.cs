using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedIn.Sdk.Model
{
    public class LinkedInCandidate
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birth { get; set; }
        public string Sex { get; set; }
        public string Country { get; set; }
        public string Technology { get; set; }
        public string Celphone { get; set; }
        public string EmailAdress { get; set; }

        public LinkedInCandidate(string name, string surname, DateTime birth, string sex, string emailAdress, string celphone, string country, string technology)
        {
            Name = name;
            Surname = surname;
            Birth = birth;
            Sex = sex;
            Country = country;
            Technology = technology;
            Celphone = celphone;
            EmailAdress = emailAdress;
        }
    }
}

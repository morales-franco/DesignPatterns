using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Solution1.Entities
{
    class Candidate
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Technology { get; set; }

        public Candidate(string name, string phone, string email, string technology)
        {
            Name = name;
            Phone = phone;
            Email = email;
            Technology = technology;
        }
    }
}

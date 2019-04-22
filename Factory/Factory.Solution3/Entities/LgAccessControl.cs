using Factory.Solution3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Solution3.Entities
{
    class LgAccessControl : IAccessControl
    {
        public string Code { get; private set; }

        public LgAccessControl()
        {
            Code = "LG";
        }

        public List<string> GetAttendeces()
        {
            List<string> attendances = new List<string>();

            for (int i = 1; i <= 4; i++)
                attendances.Add($"Attendance of { Code } Access Control - Number {i}");

            return attendances;
        }

        public List<string> GetUsers()
        {
            List<string> users = new List<string>();

            for (int i = 1; i <= 5; i++)
                users.Add($"User ID:  {i} of { Code } Access Control");

            return users;
        }

        public void SetCode(string code) => Code = code;
    }
}

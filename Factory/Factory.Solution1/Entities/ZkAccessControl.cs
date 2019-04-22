using Factory.Solution1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Solution1.Entities
{
    class ZkAccessControl : IAccessControl
    {
        public string Code { get => "ZK"; }

        public List<string> GetAttendeces()
        {
            List<string> attendances = new List<string>();

            for (int i = 1; i <= 2; i++)
                attendances.Add($"Attendance of { Code } Access Control - Number {i}");

            return attendances;
        }

        public List<string> GetUsers()
        {
            List<string> users = new List<string>();

            for (int i = 1; i <= 1; i++)
                users.Add($"User ID:  {i} of { Code } Access Control");

            return users;
        }
    }
}

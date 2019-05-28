using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.AccessControl.AccessControls
{
    class FingerprintLg: ILgAccessControl
    {
        public string Code { get; private set; }

        public FingerprintLg()
        {
            Code = "LG - FINGERPRINT";
        }


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

            for (int i = 1; i <= 3; i++)
                users.Add($"User ID:  {i} of { Code } Access Control");

            return users;
        }

        public void SetCode(string code) => Code = code;
    }
}

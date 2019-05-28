using System.Collections.Generic;

namespace AbstractFactory.AccessControl.AccessControls
{
    interface IZkAccessControl
    {
        string Code { get; }

        List<string> GetUsers();
        List<string> GetAttendeces();

        void SetCode(string code);
    }
}

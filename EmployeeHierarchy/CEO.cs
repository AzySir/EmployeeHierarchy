using System;
using System.Collections.Generic;

namespace EmployeeHierarchy
{
    public class CEO:Employee
    {
        public CEO(String Name, int StaffId)
        {
            this.ManagerId = 0;
            this.Name = Name;
        }
    }
}

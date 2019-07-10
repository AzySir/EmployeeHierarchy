using System;
using System.Collections.Generic;

namespace EmployeeHierarchy
{
    public class CEO:Manager
    {
        public CEO(String Name, int StaffId)
        {
            ManagerId = 0;
        }
    }
}

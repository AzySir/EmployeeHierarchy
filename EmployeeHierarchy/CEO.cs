using System;
using System.Collections.Generic;

namespace EmployeeHierarchy
{
    public class CEO
    {
        public String Name { get; set; }
        public int StaffId { get; set; }
        public CEO() { }

        public StaffInformation GetCEO(List<StaffInformation> StaffInfo)
        {
            StaffInformation ceo = null;
            foreach (var staff in StaffInfo)
            {
                if (staff.ManagerId == 0) {
                    ceo = staff;
                    break;
                }
            }
            return ceo;
        }
        
    }
}

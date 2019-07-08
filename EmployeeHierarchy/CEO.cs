using System;
using System.Collections.Generic;

namespace EmployeeHierarchy
{
    public class CEO
    {
        public String Name { get; set; }
        public int StaffId { get; set; }
        public List <StaffInformation> StaffList { get; set; }
        public CEO(List<StaffInformation> StaffList) {
            this.StaffList = StaffList;
            foreach(var sl in StaffList)
            {
             if (sl.ManagerId == 0)
                {
                    this.Name = sl.Name;
                    this.StaffId = sl.StaffId;
                }   
            }
        }
    }
}

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

        public List<StaffInformation> RemoveFromStaffList(List<StaffInformation> StaffList)
        {
            StaffInformation si = new StaffInformation(this.Name, this.StaffId);
            //StaffList.RemoveAt(2); //########## NEED TO REMOVE THIS ##################
            StaffList.Remove(si);
            return StaffList;
        }
    }
}

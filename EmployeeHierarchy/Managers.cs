using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeHierarchy
{
    public class Managers
    {
        List<StaffInformation> StaffList = new List<StaffInformation>();
        List<Managers> ManagerList = new List<Managers>();
        StaffInformation ceo;

        public String Name { get; set; }
        public int StaffId { get; set; }
        public int ManagerId { get; set; }

        public Managers(String Name, int StaffId, int ManagerId)
        {
            this.Name = Name;
            this.StaffId = StaffId;
            this.ManagerId = ManagerId;
        }

        public Managers(List<StaffInformation> StaffList, StaffInformation ceo)
        {
            this.StaffList = StaffList;
            this.ceo = ceo;
        }
        public List<Managers> GetManagers()
        {
            foreach(var staff in StaffList)
            {
                if (staff.ManagerId == ceo.StaffId)
                {
                    ManagerList.Add(new Managers(staff.Name, staff.StaffId, staff.ManagerId));
                }
            }
            ManagerList.OrderBy(o => o.Name).ToList();
            return ManagerList;
        }
    }
}

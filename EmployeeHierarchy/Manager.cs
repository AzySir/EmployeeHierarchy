using System;
namespace EmployeeHierarchy
{
    public class Manager
    {
        public String Name { get; set; }
        public int StaffId { get; set; }
        public int ManagerId { get; set; }
        public Manager(String Name, int StaffId, int ManagerId)
        {
            this.Name = Name;
            this.StaffId = StaffId;
            this.ManagerId = ManagerId;
        }
    }
}

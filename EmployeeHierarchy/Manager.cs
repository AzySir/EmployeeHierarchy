using System;
namespace EmployeeHierarchy
{
    public class Manager:Employee
    {
        public Manager() { }
        public Manager(String Name, int StaffId, int ManagerId)
        {
            this.Name = Name;
            this.StaffId = StaffId;
            this.ManagerId = ManagerId;
        }
    }
}

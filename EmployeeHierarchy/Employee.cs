using System;
namespace EmployeeHierarchy
{
    public class Employee
    {
        public String Name { get; set; }
        public int StaffId { get; set; }
        public int ManagerId { get; set; }
        public Employee() { }
        public Employee(String Name, int StaffId, int ManagerId)
        {
            this.Name = Name;
            this.StaffId = StaffId;
            this.ManagerId = ManagerId;
        }

        public Employee(String Name, int StaffId)
        {
            this.Name = Name;
            this.StaffId = StaffId;
        }
    }
}

using System;
namespace EmployeeHierarchy
{
    public class Employees
    {
        public Employees()
        {
        public String Name { get; set; }
        public int StaffId { get; set; }
        public int ManagerId { get; set; }
        public Employees() {
            this.Name = null;
            this.StaffId = 0;
            this.ManagerId = 0;
        }
        public Employees(String Name, int StaffId, int ManagerId)
        {
            this.Name = Name;
            this.StaffId = StaffId;
            this.ManagerId = ManagerId;
        }
    }
}

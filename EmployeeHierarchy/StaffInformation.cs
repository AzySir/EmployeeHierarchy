using System;
namespace EmployeeHierarchy
{
    public class StaffInformation
    {
        public String Name { get; set; }
        public int StaffId { get; set; }
        public int ManagerId { get; set; }
        public StaffInformation()
        {
          
        }

        public StaffInformation(String Name, int StaffId, int ManagerId)
        {
            this.Name = Name;
            this.StaffId = StaffId;
            this.ManagerId = ManagerId;
            if (ManagerId.ToString() == null) {
                Console.WriteLine("CEO Found! - " + this.Name);
            }
        }
        public StaffInformation(String Name, int StaffId)
        {
            this.Name = Name;
            this.StaffId = StaffId;
            this.ManagerId = 0;
        }
    }
}

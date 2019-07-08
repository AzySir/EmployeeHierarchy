using System;
using System.Collections.Generic;

namespace EmployeeHierarchy
{
    public class Employee
    {
        private List<StaffInformation> StaffList;
        private Dictionary<int, Employee> EmployeeList;
        private List<Managers> Managers;

        public String Name { get; set; }
        public int StaffId { get; set; }
        public int ManagerId { get; set; }

        public Employee(List<StaffInformation> StaffList, List<Managers> ManagerList)
        {
            this.StaffList = StaffList;
            this.Managers = ManagerList;
        }

        public Dictionary<int, Employee> GetEmployees()
        {
            foreach(var Manager in Managers)
                foreach (var Staff in StaffList)
                {
                    Console.WriteLine(Staff.GetType());
                    if (Manager.StaffId == Staff.ManagerId)
                    {
                        //EmployeeList.Add(ManagerId, new Employee(Staff.Name, Staff.StaffId, Staff.ManagerId));

                    }
                }
            return EmployeeList;
        }
    }
}

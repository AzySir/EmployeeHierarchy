using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeHierarchy
{
    public class EmployeeReader
    {
        private List<Employee> EmployeeList = new List<Employee>();
        public EmployeeReader()
        {
            EmployeeList.Add(new Manager("Alan", 100, 150));
            EmployeeList.Add(new Employee("Martin", 220, 100));
            EmployeeList.Add(new CEO("Jamie", 150));
            EmployeeList.Add(new Employee("Alex", 275, 100));
            EmployeeList.Add(new Manager("Steve", 400, 150));
            EmployeeList.Add(new Employee("David", 190, 400));
            //AllocateRoles();
        }
        public List<Employee> GetData()
        {
            return EmployeeList;
        }


        //public void AllocateRoles()
        //{
        //    FindCEO();
        //    FindManager();
        //}

        public void FindCEO()
        {
            List<Employee> OnlyCEOList = EmployeeList.Where(x => x.GetType() == typeof(CEO)).ToList();
        }
        public void FindManager()
        {
            List<Employee> OnlyCEOList = EmployeeList.Where(x => x.GetType() == typeof(CEO)).ToList();
            List<Employee> ManagerList = null;

            if (OnlyCEOList.Count == 1) {
                ManagerList = EmployeeList.Where(x => x.ManagerId == OnlyCEOList[0].StaffId).ToList();
            }
            else if (OnlyCEOList.Count > 1)
            {
                foreach(var ceo in OnlyCEOList)
                {
                    if (ManagerList != null)
                    {
                        ManagerList =  EmployeeList.Where(x => x.ManagerId == ceo.StaffId).ToList();
                    }
                    else
                    {
                        ManagerList.AddRange(EmployeeList.Where(x => x.ManagerId == ceo.StaffId).ToList());
                    }
                }
            }
            else
            {

            }
        }

        //public void SwapRole(Employee OldRole, Employee NewRole)
        //{
        //    EmployeeList.Remove(OldRole);
        //    EmployeeList.Add(NewRole);
        //}
    }
}

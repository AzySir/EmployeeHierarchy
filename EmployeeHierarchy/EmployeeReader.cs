using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeHierarchy
{
    public class EmployeeReader
    {
        private List<Employee> EmployeeList = new List<Employee>();
        private List<CEO> OnlyCEOList = new List<CEO>();
        public EmployeeReader()
        {
            //Create Employee list 
            EmployeeList.Add(new Manager("Alan", 100, 150));
            EmployeeList.Add(new Employee("Martin", 220, 100));
            EmployeeList.Add(new CEO("Jamie", 150));
            EmployeeList.Add(new Employee("Alex", 275, 100));
            EmployeeList.Add(new Manager("Steve", 400, 150));
            EmployeeList.Add(new Employee("David", 190, 400));
        }
        public List<Employee> GetData()
        {
            return EmployeeList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeHierarchy
{
    internal class EmployeePrinter
    {
        private List<Employee> employees = null;
        public EmployeePrinter(List<Employee> employees)
        {
            this.employees = employees;
        }

        public void PrintEmployee(Employee Emp)
        {
                Console.WriteLine("|_______|_______" + Emp.Name); //Print Employee Name
        }

        public void PrintManager(Employee Mgr)
        {
                Console.WriteLine("|_______|" + Mgr.Name + "|_______"); //Print Managers Name
        }

        public void PrintCEO(List<Employee> EmpList)
        {
            foreach (var CEO in EmpList)
                Console.WriteLine("|" + CEO.Name + "|_______|_______"); //Print CEO
        }

        public void PrintManagersAndEmployees(List<Employee> MgrList, List<Employee> EmpList)
        {
            foreach(var m in MgrList)
            {
                PrintManager(m);
                foreach (var e in EmpList)
                {
                    if (e.ManagerId == m.StaffId)
                    {
                        PrintEmployee(e);
                    }
                }
            }
            
            //PrintAllEmployees(OnlyEmployeeList);
        }

        public void PrintHierarchy()
        {
            List<Employee> OnlyEmployeeList = employees.Where(x => x.GetType() == typeof(Employee)).ToList();
            List<Employee> OnlyManagerList = employees.Where(x => x.GetType() == typeof(Manager)).ToList();
            List<Employee> OnlyCEOList = employees.Where(x => x.GetType() == typeof(CEO)).ToList();
            Console.WriteLine("______________________"); //Start
            PrintCEO(OnlyCEOList);
            PrintManagersAndEmployees(OnlyManagerList, OnlyEmployeeList);
            Console.WriteLine("______________________"); //End 

        }
    }
}

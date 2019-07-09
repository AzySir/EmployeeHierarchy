using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;

namespace EmployeeHierarchy
{
    class App
    {
        static List<StaffInformation> StaffList = new List<StaffInformation>();
        static List<Manager> ManagerList = new List<Manager>();
        static List<Employee> EmployeeList = new List<Employee>();

        public static void Main(string[] args)
        {
            displayEmployeeHierarchy();
        }

        public static void displayEmployeeHierarchy()
        {
            createData();
            CEO ceo = new CEO(StaffList); //Create new CEO 
            StaffList = ceo.RemoveFromStaffList(StaffList);
            initManager(StaffList, ceo); //Initalize the Manager List
            initEmployee(StaffList, ManagerList); //Initialize the Employee List
            PrintHierarchy(ceo, ManagerList, EmployeeList); //Print the Employee Hierarchy 
        }

        public static void createData()
        {
            //Populate the Staff List with Objects
            StaffList.Add(new StaffInformation("Alan", 100, 150));
            StaffList.Add(new StaffInformation("Martin", 220, 100));
            StaffList.Add(new StaffInformation("Jamie", 150));
            StaffList.Add(new StaffInformation("Alex", 275, 100));
            StaffList.Add(new StaffInformation("Steve", 400, 150));
            StaffList.Add(new StaffInformation("David", 190, 400));
        }

        public static void initManager(List<StaffInformation> StaffList, CEO ceo)
        {
            foreach(var sl in StaffList)
            {
                if (sl.ManagerId == ceo.StaffId)
                {
                    Manager mn = new Manager(sl.Name, sl.StaffId, sl.ManagerId);
                    if (!ManagerList.Any(x => x == mn))
                    {
                        ManagerList.Add(mn);
                    }
                }
            }
        }

        public static void initEmployee(List<StaffInformation> StaffList, List<Manager> Mgr)
        {
            foreach (var mn in Mgr) 
            {
                foreach (var sl in StaffList)
                {
                    if (sl.ManagerId == mn.StaffId)
                    {
                        EmployeeList.Add(new Employee(sl.Name, sl.StaffId, sl.ManagerId));
                    }
                }
            }
        }
        
        public static void PrintHierarchy(CEO ceo, List<Manager> FinalManagerList, List<Employee> FinalEmployeeList)
        {
            //Print CEO
            Console.WriteLine("______________________"); //Start 
            Console.WriteLine("|" + ceo.Name + "|_______|_______"); //Print CEO
            foreach (var fml in FinalManagerList) //Loop Through Managers List
            {
                Console.WriteLine("|_______|" + fml.Name + "|_______"); //Print Managers Name
                foreach (var fel in FinalEmployeeList)
                {
                    if (fel.ManagerId == fml.StaffId) //If Employee's ManagerId and ManagerId's StaffId is the same  
                    {
                        Console.WriteLine("|_______|_______" + fel.Name); //Print Employee Name
                    }
                }
            }
            Console.WriteLine("______________________"); //End 
        }
    }
}

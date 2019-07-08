using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;

namespace EmployeeHierarchy
{
    class App
    {
        public static void Main(string[] args)
        {
            //Create the Staff List
            List<StaffInformation> StaffList = new List<StaffInformation>();

            //Populate the Staff List with Objects
            StaffList.Add(new StaffInformation("Alan", 100, 150));
            StaffList.Add(new StaffInformation("Martin", 220, 100));
            StaffList.Add(new StaffInformation("Jamie", 150));
            StaffList.Add(new StaffInformation("Alex", 275, 100));
            StaffList.Add(new StaffInformation("Steve", 400, 150));
            StaffList.Add(new StaffInformation("David", 190, 400));

            //CEO List - There is 1 in the example. There coudl be more
            List<StaffInformation> CEOList = GetCEO(StaffList);

            //Manager List
            List<StaffInformation> ManagerList = new List<StaffInformation>();

            //Managers and Employees List combined = Group
            Dictionary<String, List<StaffInformation>> EmployeeAndManagerGroup = new Dictionary<String, List<StaffInformation>>();

            //Remove CEO from StaffList
            foreach (var x in CEOList)
            {
                StaffList.Remove(x);
            }

            //Find the Managers
            foreach (var CEO in CEOList)
            {   
               ManagerList = StaffList.Where(x => x.ManagerId == CEO.StaffId).ToList();
            }

            //Create Groups
            List<StaffInformation> Group = new List<StaffInformation>();
            
            foreach (var Manager in ManagerList)
            {
                //x.ManagerId = ManagerId of the Staff List Member
                //Manager.StaffId = StaffId of the Manager
                Group = StaffList.Where(x => x.ManagerId == Manager.StaffId).ToList();
                if (EmployeeAndManagerGroup.ContainsKey(Manager.StaffId + "_Group"))
                {
                    EmployeeAndManagerGroup[Manager.StaffId + "_Group"] = Group;
                }
                else
                {
                    EmployeeAndManagerGroup.Add(Manager.StaffId + "_Group", Group);
                }
            }

            
            foreach (var g in Group)
            {
                Console.WriteLine("++++++++GROUP" + g.Name + "|" + g.StaffId + "|" + g.ManagerId);
                //Console.WriteLine("++++++MANAGER" + Manager.Name + "|" + Manager.StaffId + "|" + Manager.ManagerId);
            }

            //PrintCEO(CEOList); //Print CEO
            foreach (var g in EmployeeAndManagerGroup)
                foreach (var Staff in g.Value)
                {
                    PrintEmployeeAndManagerGroup(g.Key, g.Value);
                }
        }

        public static List<StaffInformation> GetCEO(List<StaffInformation> StaffList)
        {
            List<StaffInformation> CEOList = new List<StaffInformation>();
            foreach (var Staff in StaffList)
                if (Staff.ManagerId == 0)
                {
                    CEOList.Add(Staff);
                }
            return CEOList;
        }



        public static void PrintCEO(List<StaffInformation> CEOList)
        {
            Console.WriteLine("_____________________");
            foreach(var CEO in CEOList)
                Console.WriteLine("|" + CEO.Name + "|_______|_______");
        }
        public static void PrintEmployeeAndManagerGroup(String Key, List<StaffInformation> Employees)
        {
            String[] KeyArray = Key.Split('_');
            int MyKey = Int32.Parse(KeyArray[0]);
            List<StaffInformation> Manager = Employees.Where(y => y.StaffId != MyKey).ToList();
            List<StaffInformation> NormalEmployee = Employees.Where(x => x.StaffId != MyKey).ToList();
            //Console.WriteLine(x.ManagerId + "|" + ManagerId);
            //foreach(var e in Employees)
            //{
            //    Console.WriteLine(e.Name + "|" + e.StaffId + "|" + e.ManagerId);
            //}

            foreach (var m in Manager)
            {
                Console.WriteLine("|___M____|" + m.Name + "|_______");
            }
            foreach (var e in NormalEmployee)
            {
                Console.WriteLine("|_______|____E___" + e.Name);
            }
            Console.WriteLine("_____________________");
        }
    }
}

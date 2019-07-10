using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;

namespace EmployeeHierarchy
{
    class App
    {
        static List<Employee> EmployeeList = new List<Employee>();
        
        
        public static void Main(string[] args)
        {
            displayEmployeeHierarchy(); //Call the Main Functionality
            //CEO n = new CEO("Adam", 123);
            //Employee b = new Employee("Adam", 123);

            //Console.WriteLine("CEO: "+n.Name +"|"+n.StaffId);
            //Console.WriteLine("Employee: " + b.Name + "|" + b.StaffId);
        }

        public static void displayEmployeeHierarchy()
        {
            EmployeeReader er = new EmployeeReader(); 
            EmployeeList = er.GetData();

            EmployeePrinter ep = new EmployeePrinter(EmployeeList);
            ep.PrintHierarchy();            
        }
    }
}

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
        }

        //Display Employee Hierarchy 
        public static void displayEmployeeHierarchy()
        {
            EmployeeReader er = new EmployeeReader(); 
            EmployeeList = er.GetData(); //Get Employee List

            EmployeePrinter ep = new EmployeePrinter(EmployeeList);
            ep.PrintHierarchy();  //Print Employee List
        }
    }
}

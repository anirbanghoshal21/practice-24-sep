using BusinessLogicLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Library;

namespace HelperLibrary
{
    
    public class Employee_Helper
    {
        Employee_DAL dal = null;
        public Employee_Helper()
        {
             dal = new Employee_DAL();
        }
        public bool AddEmployee(Employee_BAL employee)
        {
           return dal.InsertEmployee(employee);
        }

        public bool EditEmployee(Employee_BAL employee)
        {
            return dal.UpdateEmployee(employee);
        }

        public bool RemoveEmployee(Employee_BAL employee)
        {
            return dal.DeleteEmployee(employee_id);
        }

        public void SearchEmployee(Employee_BAL employee)
        {
            dal.FindEmployee(empid, out empdata);
        }
        public int countEmployees()
        {
            return dal.EmployeeCount();

        }
        public List<Employee_BAL> ShowEmployeeList()
        {
            return dal.EmployeeList();
        }
    }
}

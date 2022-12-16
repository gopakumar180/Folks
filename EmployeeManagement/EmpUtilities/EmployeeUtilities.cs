using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagement.EmpUtilities
{
    public class EmployeeUtilities
    {
        private Employee[] employees;
        private int current;

        public EmployeeUtilities()
        {
            current = 0;//At first current is index 0 of employee array
            getDataFromDB(); //Call this method to get data from DB
        }

        public Employee getCurrent()
        {
            return employees[current];
        }

        public Employee getPrevious()
        {
            //current=current-1
            current--;
            //Exception handling if current less than 0 set the current value to last employee
            if (current < 0)
            {
                current = employees.Length - 1;
                //current = 0;
            }
            return employees[current];
        }
        public Employee getNext()
        {
            //current=current+1
            current++;
            //Exception handling if current greater than index of last employee set the current value to 0
            if (current > employees.Length - 1)
            {
                current = 0;
            }
            return employees[current];
        }
        public Employee getEmployeeById(int id)
        {
            Employee e = null;
            for (int i = 0; i < employees.Length; i++)
            {
                //If employee number is equal to id set e has employee details
                if (employees[i].getEmployeeNo() == id)
                {
                    e = employees[i];
                    current = i;
                }
            }
            return e;
        }
        public void updateEmployee(Employee e)
        {
            DbConnection empDB = new DbConnection();
            empDB.updateEmployee(e);
        }
        public void getDataFromDB()
        {
            //create an object for EmployeeDAO class
            DbConnection empDB = new DbConnection();
            //get employee data to an arraylist
            ArrayList temp = empDB.GetEmployeeList();
            employees = new Employee[temp.Count];
            //for storing data to array from an arraylist
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = (Employee)temp[i];
            }
        }
        public void deleteEmployee(Employee e)
        {
            DbConnection empDB = new DbConnection();
            empDB.deleteEmployee(e);           
        }      
    }
}
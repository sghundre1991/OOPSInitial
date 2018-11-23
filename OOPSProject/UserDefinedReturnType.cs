using System;
namespace OOPSProject
{
    /// <summary>
    /// Employee an Entity Class
    /// </summary>
    public class Employee
    {
        private int _empNumber;

        public int EmployeeNumber
        {
            get { return _empNumber; }
            set { _empNumber = value; }
        }
        private string  _empName;

        public string  EmployeeName
        {
            get { return _empName; }
            set { _empName = value; }
        }
        private string _job;

        public string Job
        {
            get { return _job; }
            set { _job = value; }
        }
        private decimal _salary;

        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        private bool _status;

        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
    class UserDefinedReturnType
    {
        public Employee GetEmployee(int employeeNumber)
        {
            Employee employee = new Employee();
            employee.EmployeeNumber = employeeNumber;
            employee.EmployeeName = "San";
            employee.Job = "Manager";
            employee.Salary = 10000.00m;
            employee.Status = true;
            return employee;

        }


        static void Main(string[] args)
        {
            UserDefinedReturnType userDefinedReturnType = new UserDefinedReturnType();
            Employee employee= userDefinedReturnType.GetEmployee(1001);
            Console.WriteLine(employee.EmployeeNumber + " " + employee.EmployeeName + employee.Job + employee.Salary + employee.Status);
            Console.ReadLine();
        }
    }
}
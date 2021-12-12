using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Employee employee1 = new Employee();
            employee1.Name = "emre";
            employee1.Surname = "issever";
            employee1.No = 21312312;
            employee1.Department = "Information Technology";

            employee1.EmployeeInformations();

            System.Console.WriteLine("*****************************");

            Employee employee2 = new Employee();
            employee2.Name = "deniz";
            employee2.Surname = "arda";
            employee2.No = 123213;
            employee2.Department = "purchasing department";

            employee2.EmployeeInformations();



        }
    }

    class Employee
    {
        public string Name;
        public string Surname;
        public int No;
        public string Department;

        public void EmployeeInformations(){
            System.Console.WriteLine("Employee Name : {0}",Name);
            System.Console.WriteLine("Employee Surname : {0}",Surname);
            System.Console.WriteLine("Employee No : {0}",No);
            System.Console.WriteLine("Employee Department : {0}",Department);


        }
    }
}

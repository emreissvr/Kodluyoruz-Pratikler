using System;

namespace AccessModifiers_ConstructorFunctios
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("************* Employee 1 ****************");
            Employee employee1 = new Employee("emre","issever",21312312,"Information Technology");
            employee1.EmployeeInformations();


            System.Console.WriteLine("************* Employee 2 ****************");
            

            Employee employee2 = new Employee();
            employee2.Name = "deniz";
            employee2.Surname = "arda";
            employee2.No = 123213;
            employee2.Department = "purchasing department";
            employee2.EmployeeInformations();

            System.Console.WriteLine("************* Employee 3 ****************");
            Employee employee3 = new Employee("mehmet","dönmez");
            employee3.EmployeeInformations();  // Employee No = 0 and Employee Department = NULL

        }
    }

    
    class Employee
    {
        public string Name;
        public string Surname;
        public int No;
        public string Department;

        public Employee(string name, string surname, int no, string department){
            this.Name = name;
            this.Surname = surname;
            this.No = no;
            this.Department = department;
            
        }

         public Employee(string name, string surname){
            this.Name = name;
            this.Surname = surname;
          
            
        }

        public Employee(){}

        public void EmployeeInformations(){
            System.Console.WriteLine("Employee Name : {0}",Name);
            System.Console.WriteLine("Employee Surname : {0}",Surname);
            System.Console.WriteLine("Employee No : {0}",No);
            System.Console.WriteLine("Employee Department : {0}",Department);


        }
    }

    
}


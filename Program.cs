using System;

namespace StaticClassesAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Number of employee: {0}",Employee.NumberOfEmployee);
            Employee employee = new Employee("Ayşe","Yılmaz","İK");
            System.Console.WriteLine("Number Of employee : {0}",Employee.NumberOfEmployee);

            
            System.Console.WriteLine("Result of the Addition : {0}", Transactions.Add(100,200) );
            System.Console.WriteLine("Result of the Substract : {0}", Transactions.Substract(400,200) );


        }
    }

    class Employee
    {
        private static int numberOfEmployee;
        public static int NumberOfEmployee { get => numberOfEmployee; }

        private string Name;
        private string Surname;

        private string Department;


        static Employee(){
            numberOfEmployee = 0;
        }
        public Employee(string name, string surname,string department)
        {
            
            this.Name = name;
            this.Surname = surname;
            this.Department = department;
            numberOfEmployee++;
        }


    }


    static class Transactions{
        public static long Add(int sayi1, int sayi2){
            return sayi1 + sayi2;
        }
        public static long Substract(int sayi1, int sayi2){
            return sayi1 - sayi2;
        }
    }


}

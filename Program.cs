using System;

namespace EncapsulationAndProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Student student = new Student();
            student.Name = "Emre";
            student.Surname = "Issever";
            student.StudentNumber = 123;
            student.TheClass = 3;
            student.StudentInformationGetter();

        }
    }

    class Student{

        private string name;
        private string surname;
        private int studentNumber;

        private int theClass;

        public string Name 
        {
             get {return name;} 
             set {name = value;} 
        }
         public string Surname 
        {
             get {return surname;} 
             set {surname = value;} 
        }

        public int StudentNumber 
        {
             get {return studentNumber;} 
             set {studentNumber = value;} 
        }

        public int TheClass 
        {
             get => theClass; 
             set {
                 
             } 
        }


        public Student(string name, string surname, int studentNumber, int theClass){
            Name = name;
            Surname = surname;
            StudentNumber = studentNumber;
            TheClass = theClass;

        }

        public Student(){

        }

        public void StudentInformationGetter(){
            System.Console.WriteLine("********** Student Informations**********");
            System.Console.WriteLine("Student Name : {0}",this.Name);
            System.Console.WriteLine("Student Surname : {0}", this.Surname);
            System.Console.WriteLine("Student No : {0}", this.StudentNumber);
            System.Console.WriteLine("Student Class : {0}",this.TheClass);

        }

        public void ClassPlus()
        {
            this.TheClass = this.TheClass + 1;
        }

        public void ClassMinus()
        {
            this.TheClass = this.TheClass - 1;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Day1HW
{
    class Person
    {
        protected int age;
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public void SetAge(int n)
        {
            age = n;
        }
    }

    class Student : Person
    {
        public void GoToClass()
        {
            Console.WriteLine("I'm going to class.");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is: " + this.age + " years old");
        }
    }

    class Teacher : Person
    {
        private string subject;
        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
    }

    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Person per = new Person();
            per.Greet();
            Console.WriteLine();

            Student std = new Student();
            std.SetAge(21);
            std.Greet();
            std.ShowAge();
            Console.WriteLine();

            Teacher tch = new Teacher();
            tch.SetAge(30);
            tch.Greet();
            tch.Explain();
            Console.WriteLine();
        }
    }
    //class Program
    //{
        
    //}
}

using System;

namespace OOPSQuestions
{
    class StudentProfessor
    {
        public static void Main()
        {
            Person myPerson = new Person();
            myPerson.Greet();

            Student myStudent = new Student();
            myStudent.SetAge(21);
            myStudent.Greet();
            myStudent.ShowAge();
            myStudent.Study();

            Professor myProfessor = new Professor();
            myProfessor.SetAge(30);
            myProfessor.Greet();
            myProfessor.Explain();
        }
    }

    public class Person
    {
        protected int age;

        public void Greet()
        {
            Console.WriteLine("Hello!");
        }

        public void SetAge(int n)
        {
            age = n;
        }
    }

    public class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }

        public void ShowAge()
        {
            Console.WriteLine("My age is {0} years old", age);
        }
    }

    public class Professor : Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }
}
   

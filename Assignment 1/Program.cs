using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var teacher = new Teacher();
            Teacher.name = "Angela";
            Teacher.gender = "female";
            Teacher.subject = "Mathematics";
            Teacher.classes = "SS2";
            teacher.TeacherInformation();
            Console.WriteLine(" ");

            var student = new Student();
            Student.name = "Gbenga";
            Student.age = 16;
            Student.gender = "male";
            Student.classes = "SS2";
            Student.subject = "physics";
            student.StudentInformation();
            Console.WriteLine(" ");

            Console.WriteLine("Hello World!");
            Console.WriteLine();
        }
    }
    public class Teacher
    {
        public static string name;
        public static string gender;
        public static string classes;
        public static string subject;


        public void TeacherInformation()
        {
            Console.WriteLine("Hello, my name is {0}. I am a {1} and I teach {2} in {3}. ",name,gender,subject,classes);
        }
    }

    public class Student:Teacher
    {
        public static int age;

        public void StudentInformation()
        {
            Console.WriteLine("{0} is a {1} years old {2} in {3} and he is the best in {4}.",name,age,gender,classes,subject);
        }
    }
}

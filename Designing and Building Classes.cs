using System;

namespace _OOP
 {


    public abstract class Person
    {
        public DateTime BirthDay;
        public decimal Salary;
        public string Address;

        public int GetAge()
        {
            DateTime now = DateTime.Now;
            int age = now.Year - BirthDay.Year;
            return age;
        }

        public abstract decimal GetSalary();

        public void UpdateAddress(string NewAdd)
        {
            Address = NewAdd;
        }
    }

    public class Instructor : Person
    {
        public string Department;
        public Boolean ifHead;
        public DateTime JoinDay;

        public override decimal GetSalary()
        {
            if (Salary >= 0)
            {
                DateTime now = DateTime.Now;
                int experience = now.Year - JoinDay.Year;

                return Salary*(1+experience*(decimal)0.05);
            }
            else
            {
                return 0;
            }

        }
    }


    public class Student : Person
    {
        public string[] course;
        public string[] grades;

        public override decimal GetSalary()
        {
            return 0;

        }
        public double GetGPA()
        {
            int Grade = 0;
            foreach(string item in grades)
            {
                if (item == "A")
                {
                    Grade += 4;
                }else if (item == "B")
                {
                    Grade += 3;
                }
                else if (item == "C")
                {
                    Grade += 2;
                }
                else if (item == "D")
                {
                    Grade += 1;
                }

            }
            return (double)Grade/grades.Length;
        }
    }


    public class Course
    {
        public string[] Students;
    }


    public class Department
    {
        public string HeadInstructor;
        public double Budget;
        public DateTime StartDtime;
        public DateTime EndDtime;
        public string[] Courses;
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person Student = new Student();
            Person Instructor = new Instructor();
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    public class PrgramUniversity
    {
        public PrgramUniversity(int id, string name)
        {
            Id = id;
            Name = name;
            students = new List<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> students { get; set; }
        public void printStudents()
        {
            foreach (Student item in students)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.firstName);
                Console.WriteLine(item.lastName);
                Console.WriteLine("-----------");
            }
        }
    }
    public class Student
    {
        public Student(int id, string firstName, string lastName)
        {
            Id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            studentCourses=new List<StudentCourses>();
        }

        public int Id { get; set; }
        public string firstName { get; set; }
        public string  lastName { get; set; }
        public PrgramUniversity prgramUniversity { get; set; }
        public List<StudentCourses> studentCourses { get; set; }
        public int getRegistredCourses()
        {
            return studentCourses.Count;
        }
        public void printStudentInformation()
        {
            Console.WriteLine($"{Id} : {firstName} {lastName}");
            if (studentCourses.Count ==0)
            {
                Console.WriteLine("No Courses Registred Yet.");
            }
            else
            {
                foreach (StudentCourses item in studentCourses)
                {
                    Console.WriteLine($"{item.course.CourseName} {item.course.coursePrice} {item.joinDate} {item.isPaid}");
                }
            }

        }

    }
    public class Course
    {
        public Course()
        {

        }
        public Course(int id, string courseName, int coursePrice)
        {
            Id = id;
            CourseName = courseName;
            this.coursePrice = coursePrice;
            studentCourses = new List<StudentCourses>();
        }

        public int Id { get; set; }
        public string CourseName { get; set; }
        public int coursePrice { get; set; }
        public List<StudentCourses> studentCourses { get; set; }
        public int getTotalRegistered()
        {
            return studentCourses.Count();
        }
    }
    public class StudentCourses
    {
        public StudentCourses(int id, Student student, Course course, bool isPaid, DateTime joinDate)
        {
            Id = id;
            this.student = student;
            this.course = course;
            this.isPaid = isPaid;
            this.joinDate = joinDate;
        }

        public int Id { get; set; }
        public Student student { get; set; }
        public Course course { get; set; }
        public bool isPaid { get; set; }
        public DateTime joinDate { get; set; }
    }
}

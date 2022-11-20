using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    public class Student
    {
        public Student(string firstName, string lastName, string gender, int fees)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.fees = fees;
        }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int fees { get; set; }
        public static int getTotalFees(List<Student> students)
        {
            int totalFees = 0;
            foreach (Student item in students)
            {
                totalFees += item.fees;
            }
            return totalFees;
        }
        public static int getMaleTotalFees(List<Student> students)
        {
            int totalFees = 0;
            foreach (Student item in students)
            {
                if (item.gender == "male")
                {
                    totalFees += item.fees;
                }
            }
            return totalFees;
        }
        public static int getFemaleTotalFees(List<Student> students)
        {
            int totalFees = 0;
            foreach (Student item in students)
            {
                if (item.gender == "female")
                {
                    totalFees += item.fees;
                }
            }
            return totalFees;
        }
    }
}

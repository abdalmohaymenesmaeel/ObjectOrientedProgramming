namespace StaticMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object Variable
            //Class Variable

            //Object Method
            //Class Method
            Student st1 = new Student("Mostfa", "Darweesh", "male", 350);
            Student st2 = new Student("ahmad", "kurdy", "male", 300);
            Student st3 = new Student("fatemah", "khalil", "female", 250);
            Student st4 = new Student("nour", "alomar", "female", 350);
            Student st5 = new Student("sami", "alkadery", "male", 350);
            Student st6 = new Student("reem", "aljasem", "female", 200);

            List<Student> students = new List<Student>();
            students.Add(st1);
            students.Add(st2);
            students.Add(st3);
            students.Add(st4);
            students.Add(st5);
            students.Add(st6);
            int totalFees = Student.getTotalFees(students);
            Console.WriteLine($"Total Fees:{totalFees}");
            int totalMaleFees = Student.getMaleTotalFees(students);
            Console.WriteLine($"Total Male Fees:{totalMaleFees}");
            int totalfemaleFees = Student.getFemaleTotalFees(students);
            Console.WriteLine($"Total Female Fees:{totalfemaleFees}");
        }
    }
}
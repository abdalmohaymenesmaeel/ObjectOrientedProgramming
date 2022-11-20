namespace Composition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrgramUniversity pu = new PrgramUniversity(1, "IT");
            //pu.students.Count;
            Student s1 = new Student(1, "ahmad", "alomar");
            Student s2 = new Student(2, "omad", "alibraheem");
            Student s3 = new Student(10, "hasan", "abrash");
            Student s4 = new Student(12, "rasheed", "bakkour");
            pu.students.Add(s1);
            pu.students.Add(s2);
            pu.students.Add(s3);
            pu.students.Add(s4);
            pu.printStudents();
            s1.prgramUniversity = pu;
            s2.prgramUniversity = pu;
            s3.prgramUniversity = pu;
            s4.prgramUniversity = pu;
            Console.WriteLine(s1.prgramUniversity.Name);

            Course c1 = new Course(1,"OOP",22);
            Course c2 = new Course(2,"DB",22);
            Course c3 = new Course(5,"Net",25);
            Course c4 = new Course(7,"OS",25);
            Course c5 = new Course(8,"Calc",15);
            Course c6 = new Course(11,"SEng",15);

            StudentCourses join1 = new StudentCourses(1, s1, c1, true, DateTime.Now);
            StudentCourses join2 = new StudentCourses(2, s1, c2, true, DateTime.Now);
            StudentCourses join3 = new StudentCourses(3, s1, c3, true, DateTime.Now);
            StudentCourses join4 = new StudentCourses(4, s1, c4, true, DateTime.Now);
            StudentCourses join5 = new StudentCourses(5, s1, c5, true, DateTime.Now);
            StudentCourses join6 = new StudentCourses(6, s2, c1, false, DateTime.Now);
            StudentCourses join7 = new StudentCourses(7, s2, c2, false, DateTime.Now);
            StudentCourses join8 = new StudentCourses(8, s2, c3, false, DateTime.Now);
            StudentCourses join9 = new StudentCourses(9, s2, c4, false, DateTime.Now);
            StudentCourses join10 = new StudentCourses(15,s2,c5, false, DateTime.Now);
            StudentCourses join11 = new StudentCourses(20,s2,c6, false, DateTime.Now);
            s1.studentCourses.Add(join1);
            s1.studentCourses.Add(join2);
            s1.studentCourses.Add(join3);
            s1.studentCourses.Add(join4);
            s1.studentCourses.Add(join5);
            s2.studentCourses.Add(join6);
            s2.studentCourses.Add(join7);
            s2.studentCourses.Add(join8);
            s2.studentCourses.Add(join9);
            s2.studentCourses.Add(join10);
            s2.studentCourses.Add(join11);

            c1.studentCourses.Add(join1);
            c1.studentCourses.Add(join6);
            c2.studentCourses.Add(join2);
            c2.studentCourses.Add(join7);
            c3.studentCourses.Add(join3);
            c3.studentCourses.Add(join8);
            c4.studentCourses.Add(join4);
            c4.studentCourses.Add(join9);
            c5.studentCourses.Add(join5);
            c5.studentCourses.Add(join10);
            c6.studentCourses.Add(join11);

            Console.WriteLine("S1 Number Of Courses is :"+ s1.getRegistredCourses());
            s1.printStudentInformation();
            Console.WriteLine("S2 Number Of Courses is :"+ s2.getRegistredCourses());
            s2.printStudentInformation();
            Console.WriteLine("S3 Number Of Courses is :"+ s3.getRegistredCourses());
            s3.printStudentInformation();
            /*            PrgramUniversity pu = new PrgramUniversity(1, "IT");
                        Student st = new Student(1, "ahmad", "samer");
                        st.prgramUniversity = pu;
                        pu.students.Add(st);
                        Student st1 = new Student(2, "kahlid", "samer");
                        pu.students.Add(st1);
                        st1.prgramUniversity = pu;
                        Student st2 = new Student(3, "hameed", "samer");
                        pu.students.Add(st2);
                        st2.prgramUniversity = pu;
                        Student st3 = new Student(4, "ramy", "samer");
                        pu.students.Add(st3);
                        st3.prgramUniversity = pu;
                        //pu.printStudents();*/

            //Console.WriteLine(st3.prgramUniversity.Id);
        }
    }
}
namespace IntroductionOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Employee emp = new Employee()
            {
                ID=1,
                firstName="ahmad",
                lastName="alkhateeb"
            };
            emp.print();

            /*            //اذكر طرائق التعديل او الاسناد للواصفات ضمن الغرض
             *            //proprties set
             *            //proprties direct
             *            //Constractor
             *            //Method (function)
             *            //Special Assigneing 
                        Student student1 = new Student();
                        student1.Id = 1;
                        student1.firstName = "ahmad";
                        student1.lastName = "khaled";
                        student1.GBA = 3.4f;
                        student1.level = 3;

                        Student student2 = new Student();
                        student2.Id = 2;
                        student2.firstName = "ramy";
                        student2.lastName = "mahmoud";
                        student2.GBA = 2.4f;
                        student2.level = 2;

                        Student student3 = new Student(3);
                        student3.firstName = "sameer";
                        student3.lastName = "alkhateeb";
                        student3.GBA = 3;
                        student3.level = 3;
                        Console.WriteLine("----------");
                        Student student4 = new Student(4, "ali", "taha", 3, 2);
                        student1.print();
            */
            /*            Student student = new Student();
                        student.setId(1);
                        student.print();
                        student.setFirstName("ismaeel");
                        student.print();
                        student.setlastName("mohammad");
                        student.print();
                        student.setGBA(2);
                        student.print();
                        student.setLevel(2);
                        student.print();*/
            /*            Student student = new Student();
                        student.setValues(1, "ahmad", "alkhaled", 3.7f, 4);
                        student.print();*/
            Course course = new Course();
            course.ID = -5;
            course.CourseName = "Programming";
            course.CoursePrice = 120;
            Console.WriteLine("=====");
            Console.WriteLine(course.ID);
            Console.WriteLine(course.CourseName);
            Console.WriteLine(course.CoursePrice);
        }
    }
    public class Course
    {
        private int id;
        public int ID { 
            get { return id; } 
            set {

                Console.WriteLine(value);
                if (value>0)
                {
                    id = value;
                }
                else
                {
                    throw new Exception("Id Value Must be grater than zero");
                }
                
                //id = value;
            
            } }
        private string courseName;
        public string CourseName { 
            get { return courseName; } 
            set {
                //Console.WriteLine("We are in Course Name Assigining");
                Console.WriteLine(value);
                //courseName = value;
                } }
        private int coursePrice;
        public int CoursePrice { 
            get { return coursePrice; } 
            set {
                //Console.WriteLine("We are in Course Price Assigining");
                Console.WriteLine(value);
                //coursePrice = value; 
            } }
    }
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("Running from Clean Constractor");
        }
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public void print()
        {
            Console.WriteLine($"ID:{ID}");
            Console.WriteLine($"First Name:{firstName}");
            Console.WriteLine($"Last Name:{lastName}");
        }
    }

    public class Student
    {
        //Constractor OverLoading
        public Student()
        {
            Console.WriteLine("Constractor withour parameters");
        }
        public Student(int id)
        {
            Id= id;
            Console.WriteLine("Constractor with parameters");
        }
        public Student(string fn)
        {

        }
        public Student(int Id,string fn,string lastName,float gba,int lvl)
        {
            Console.WriteLine("Constractor with full paramters");
            this.Id = Id;
            this.firstName = fn;
            this.lastName = lastName;
            this.GBA = gba;
            this.level = lvl;
        }
        public int Id;
        public string firstName;
        public string lastName;
        public float GBA;
        public int level;
        // no input no output (return)         // no input withput        //with input no output        //wiht input with output
        public void print()
        {
            Console.WriteLine($"ID:{Id}");
            Console.WriteLine($"First Name:{this.firstName}");
            Console.WriteLine($"Last Name:{lastName}");
            Console.WriteLine($"GBA:{GBA}");
            Console.WriteLine($"LEVEL:{level}");
        }
        public void setId(int newId)
        {
            this.Id = newId;
        }
        public void setFirstName(string newFn)
        {
            this.firstName = newFn;
        }
        public void setlastName(string newLn)
        {
            this.lastName = newLn;
        }
        public void setGBA(float gba)
        {
            this.GBA = gba;
        }
        public void setLevel(int lvl)
        {
            level = lvl;
        }
        public void setValues(int Id, string fn, string lastName, float gba, int lvl)
        {
            Console.WriteLine("Running From Method");
            this.Id = Id;
            this.firstName = fn;
            this.lastName = lastName;
            this.GBA = gba;
            this.level = lvl;
        }
    }
}
namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            print();
            print("admin", "1234");
            print("admin", "1234", "welcome");
            string fn=fullName("mohammad", "alkhateem");
            Console.WriteLine(fn);
            Console.WriteLine(fullName("ahmad", "alomar"));
            Console.WriteLine(getPI());
            int x = getFact(10);
            Console.WriteLine(x);
        }
        //getFact(10)
        //10+gf(9)
        //10+9+gf(8)
        //10+9+8+gf(7)
        //10+9+8+0

        public static int getFact(int num)
        {
            if (num==7)
            {
                return 0;
            }
            return num+getFact(num-1);
        }
        public static double getPI()
        {
            return 3.14;
        }
        public static string fullName(string firstname,string lastname)
        {
            return firstname +" "+ lastname;
        }
        public static void print()
        {
            Console.WriteLine("Welcome in our session");
        }        
        public static void print(string un,string pw)
        {
            Console.WriteLine($"{un},{pw}");
        }

        public static void print(string un, string pw,string token)
        {
            Console.WriteLine($"{un},{pw},{token}");
        }
        //input ,nooutput
        //noinput,nooutput
        //input,output
        //noinput,output
    }
}
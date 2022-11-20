namespace OOPGeneralProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //byte=0,255,sbyte = -128 127
            uint x = 4000000000;
            //short,ushort
            //short y = 65000;
            //float,double,decimal
            //variables
            //input and output
            //data types
            //comments
            //operations
            //conditions
            //loops
            /*            int x = 10;
                        byte t = 200;
                        short y = 66;
                        long u = 999;
                        bool b=true;
                        string s = "Welcome";
                        char ch = 'g';
                        double d = 44;
                        float f = 99f;
                        string firstName = "abd";*/
            //Console.Write("Welcome ");
            //Console.Write("Welcome ");
            //Console.Write("Welcome");
            /*            int x = 10;
                        int y = 15;
                        int z = x + y;
                        int u = x - y;
                        int i = x * y;
                        double o =Convert.ToDouble(x) /Convert.ToDouble(y);
                        int t = x % y;
                        Console.WriteLine(z);
                        Console.WriteLine(u);
                        Console.WriteLine(i);
                        Console.WriteLine(o);
                        Console.WriteLine(t);*/
            /*            bool b = true;
                        bool n = true;
                        bool r=b && n;
                        Console.WriteLine(r);*/
            //Console.WriteLine("Enter Your Birth Year");
            //string bystr=Console.ReadLine();
            //int by=Convert.ToInt32(bystr);
            //int = 4 byt = 32
            //Convert.ToInt64()
            //Convert.ToInt16
            /*            Console.WriteLine(DateTime.Now.Hour);
                        double by = Convert.ToDouble(Console.ReadLine());
                        if (by>1900 && by <= DateTime.Now.Year)
                        {
                            Console.WriteLine(DateTime.Now.Year - by);
                        }*/
            /*            Console.WriteLine("Enter your average");
                        int avg=Convert.ToInt32(Console.ReadLine());
                        if (avg>=0 && avg <=100)
                        {
                            if (avg < 60)
                            {
                                Console.WriteLine("Sorray you are Failed");
                            }else if (avg < 70 && avg > 59)
                            {
                                Console.WriteLine("Success");
                            }
                            else if (avg < 80 && avg > 69)
                            {
                                Console.WriteLine("good");
                            }
                            else if (avg < 90 && avg > 79)
                            {
                                Console.WriteLine("very good");
                            }
                            else
                            {
                                Console.WriteLine("Excellent");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Average");
                        }*/
            /*          Console.WriteLine("Enter Number Of Cupes");
                        int enterCupeCount=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Drinking Type:");
                        Console.WriteLine("0 Coffe : price 10");
                        Console.WriteLine("1 Tea : price 5 ");
                        Console.WriteLine("2 Orange : price 25");
                        int dt=Convert.ToInt32(Console.ReadLine());
                        switch (dt) {
                            case 0:
                                Console.WriteLine(enterCupeCount*10);
                                break;
                            case 1:
                                Console.WriteLine(enterCupeCount*5);
                                break;
                            case 2:
                                Console.WriteLine(enterCupeCount * 25);
                                break;
                            default:
                                Console.WriteLine("Invalid Drinking type");
                                break;
                        }*/
            /*            int x = 10;
                        int y = x++ + ++x - --x;
                        //      10 +  12 - 11
                        //
                        Console.WriteLine(y);
                        //11
                        //10
                        int u = ++x;
                        //x=x+1
                        //int y=x;*/
            //int counter = 0;
            /*            while (true)
                        {
                            Console.WriteLine("Enter Squer Length:");
                            int len = Convert.ToInt32(Console.ReadLine());
                            for (int j = 0; j < len; j++)
                            {
                                for (int i = 0; i < len; i++)
                                {
                                    if (i == j)
                                    {
                                        Console.Write(" ");
                                    }
                                    else
                                    {
                                        Console.Write("*");
                                    }
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine("Do you need to stop:");
                            string? isstop = Console.ReadLine();
                            if (isstop == "s")
                            {
                                break;
                            }
                            //counter++;
                        }*/
            Console.WriteLine("Enter num1:");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num2<num1)
            {
                int temp=num2;
                num2=num1;
                num1 = temp;
            }
            int total = 0;
            while (num1 <= num2)
            {
                total+=num1;
                num1++;
            }
            Console.WriteLine(total);
        }
    }
}
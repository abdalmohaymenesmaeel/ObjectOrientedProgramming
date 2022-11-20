namespace StaticVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(10);
/*            Console.WriteLine(c.getArea());
            Console.WriteLine(c.getPrim()) ;
            Console.WriteLine(c.Radius);*/
            Circle c2 = new Circle(5); 
            Circle c3 = new Circle(10);
            Circle circle = new Circle(5);
            Console.WriteLine(Circle.count);
            List<Circle> cls = new List<Circle>() ;
            cls.Add(c);
            cls.Add(c2);
            cls.Add(c3);
            cls.Add(circle);

            double total=Circle.getTotalAreas(cls);
            Console.WriteLine(total);

        }
    }
    public class Circle
    {
        public static int count = 0;
        public Circle()
        {
            count++;
        }
        public Circle(double radius)
        {
            count++;
            Radius = radius;
        }

        public double Radius { get;private set; }
        public double getArea()
        {
            return Math.PI * Radius*Radius;
        }
        public double getPrim()
        {
            return Math.PI * 2 * Radius;
        }
        public static double getTotalAreas(List<Circle> circles)
        {
            double total = 0;
/*            for (int i = 0; i < circles.Count; i++)
            {
                total += circles[i].getArea();
                Console.WriteLine(circles[i].getArea());
            }*/
            Console.WriteLine("-----------------");
            foreach (Circle item in circles)
            {
                total += item.getArea();
                Console.WriteLine(item.getArea());
            }
            return total;
        }
    }
}
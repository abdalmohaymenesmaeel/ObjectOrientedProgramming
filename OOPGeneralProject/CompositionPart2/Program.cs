namespace CompositionPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees em = new Employees(1, "ahmad", "alkhateeb", 200);
            EmployeeSalaries s1 = new EmployeeSalaries(1, 2020, 1, 200, DateTime.Now);
            s1.employees = em;
            EmployeeSalaries s2 = new EmployeeSalaries(33, 2020, 2, 200, DateTime.Now);
            s2.employees = em;
            EmployeeSalaries s3 = new EmployeeSalaries(55, 2020, 3, 200, DateTime.Now);
            EmployeeSalaries s4 = new EmployeeSalaries(70, 2020, 4, 200, DateTime.Now);
            EmployeeSalaries s5 = new EmployeeSalaries(101, 2020,5, 220, DateTime.Now);
            EmployeeSalaries s6 = new EmployeeSalaries(102, 2020, 6, 220, DateTime.Now);
            EmployeeSalaries s7 = new EmployeeSalaries(150, 2020, 7, 220, DateTime.Now);
            EmployeeSalaries s8 = new EmployeeSalaries(300, 2020, 8, 220, DateTime.Now);
            EmployeeSalaries s9 = new EmployeeSalaries(320, 2020, 9, 230, DateTime.Now);
            em.employeeSalaries.Add(s1);
            em.employeeSalaries.Add(s2);
            em.employeeSalaries.Add(s3);
            em.employeeSalaries.Add(s4);
            em.employeeSalaries.Add(s5);
            em.employeeSalaries.Add(s6);
            em.employeeSalaries.Add(s7);
            em.employeeSalaries.Add(s8);
            em.employeeSalaries.Add(s9);

            int total = em.getTotalSalaries();
            Console.WriteLine(total);

        }
    }
}
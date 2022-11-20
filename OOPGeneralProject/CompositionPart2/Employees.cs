using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionPart2
{
    public class Employees
    {
        public Employees(int id, string firstName, string lastName, int basicSalary)
        {
            Id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            BasicSalary = basicSalary;
            employeeSalaries = new List<EmployeeSalaries>();
        }

        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int BasicSalary { get; set; }
        public List<EmployeeSalaries> employeeSalaries { get; set; }
        public int getTotalSalaries(){ 
                int total = 0;  
                foreach (EmployeeSalaries es in employeeSalaries)
                {
                    total += es.mount;
                }
                return total;
        }
    }
    public class EmployeeSalaries
    {
        public EmployeeSalaries(int id, int year, int month, int mount, DateTime dateToken)
        {
            Id = id;
            this.year = year;
            this.month = month;
            this.mount = mount;
            this.dateToken = dateToken;
        }

        public int Id { get; set; }
        public int year { get; set; }
        public int month { get; set; }
        public int mount { get; set; }
        public DateTime dateToken { get; set; }
        public Employees employees { get; set; }

    }
}

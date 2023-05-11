using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1=new Employee () { Id=1, FirstName="John", LastName="Doe"};
            Employee emp2=new Employee () { Id=2, FirstName="Jane", LastName="Doe" };

            if (emp1 == emp2)
            {
                Console.WriteLine("Employees are equal.");
            }
            else
            {
                Console.WriteLine("Employees are not equal");
            }
            
        }
    }
}

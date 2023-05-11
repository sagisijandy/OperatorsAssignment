using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator ==(Employee emp1, Employee emp2) 
        {
            return emp1.Id == emp2.Id;
        }
        public static bool operator !=(Employee emp1, Employee emp2) 
        {
            return !(emp1 == emp2);
        }

          

    }
}

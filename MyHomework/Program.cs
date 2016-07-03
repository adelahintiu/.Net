using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Popescu", "Alex", "24-03-1992", "20-10-2014", 2500, 10);
            Employee e2 = new Employee("Dan", "Catalin", "05-10-1994", "10-06-2015", 3000, 6);
            Employee e3 = new Employee("Dumitrescu", "Ioana", "13-12-1993", "01-07-2016", 1500, 20);

            Leave l1 = new Leave("10-06-2016", 5, "medical");
            Leave l2 = new Leave("29-06-2016", 7, "holiday");
            Leave l3 = new Leave("15-06-2016", 10, "other");

            e1.AddNewLeave(l1);
            e1.displayInfo(e1);

            e2.AddNewLeave(l2);
            e2.displayInfo(e2);

            e3.AddNewLeave(l3);            
            e3.displayInfo(e3);




        }
    }
}

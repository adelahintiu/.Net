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
            Employee employee1 = new Employee("Popescu", "Alex", new DateTime(1992, 03, 29), new DateTime(2016, 03, 06), 2500, 10);
            Employee employee2 = new Employee("Dan", "Catalin", new DateTime(1994, 06, 05), new DateTime(2015, 06, 16), 3000, 6);
            Employee employee3 = new Employee("Dumitrescu", "Ioana", new DateTime(1993, 12, 13), new DateTime(2016, 01, 17), 1500, 20);

            Leave leave1 = new Leave(new DateTime(2016, 06, 10), 5, leaveType.medical);
            Leave leave2 = new Leave(new DateTime(2016, 06, 29), 7, leaveType.holiday);
            Leave leave3 = new Leave(new DateTime(2016, 03, 06), 10, leaveType.other);

            employee1.AddNewLeave(leave1);
            employee1.DisplayInfo(employee1);

            employee2.AddNewLeave(leave2);
            employee2.DisplayInfo(employee2);

            employee3.AddNewLeave(leave3);
            employee3.DisplayInfo(employee3);

        }
    }
}

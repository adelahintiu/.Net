using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    public class Employee : Person
    {
        readonly DateTime dateOfEmployment;
        readonly int salary;
        int availableDaysOff;
        List<Leave> listLeaves;

        public Employee(string lastName, string firstName, DateTime dateOfBirth, DateTime dateOfEmployment, int salary, int availableDaysOff) : base(lastName, firstName, dateOfBirth)
        {
            this.dateOfEmployment = dateOfEmployment;
            this.salary = salary;
            this.availableDaysOff = availableDaysOff;
             
        }

        public void DisplayInfo(Employee employee)
        {
            Console.WriteLine("Lastname : {0}", employee.lastName);
            Console.WriteLine("Firstname: {0}", employee.firstName);
            Console.WriteLine("Salary: {0}", employee.salary);
            Console.WriteLine("Number available days off: {0}", availableDaysOff);
        }

        private void SubstractDays(int numberDaysOff)
        {
            
            availableDaysOff = availableDaysOff - numberDaysOff; 
        }


        public void AddNewLeave(Leave leave)
        {
            try
            {
                if ((leave.stratingDate.Year == DateTime.Now.Year) && (availableDaysOff < leave.duration))
                {
                    throw (new NegativeLeaveDaysException ());
                }
                else
                {
                    SubstractDays(leave.duration);
                    leave.employee = this;
    
                    
                }
            }
            catch(NegativeLeaveDaysException e)
            {
                Console.WriteLine("Numarul de zile ramase nu poate fi mai mare decat durata concediului");
            }
        }



    }
}

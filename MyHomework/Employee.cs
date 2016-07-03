using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    public class Employee : Person
    {
        string dateOfEmployment;
        int salary;
        int availableDaysOff;
        List<Leave> listLeaves;

        public Employee(string lastName, string firstName, string dateOfBirth, string dateOfEmployment, int salary, int availableDaysOff) : base(lastName, firstName, dateOfBirth)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.dateOfBirth = dateOfBirth;
            this.dateOfEmployment = dateOfEmployment;
            this.salary = salary;
            this.availableDaysOff = availableDaysOff;
           
        }

        public void displayInfo(Employee e)
        {
            Console.WriteLine("Lastname : {0}", e.lastName);
            Console.WriteLine("Firstname: {0}", e.firstName);
            Console.WriteLine("Salary: {0}", e.salary);
            Console.WriteLine("Number available days off: {0}", availableDaysOff);
        }

        private void substractDays(int numberDaysOff)
        {
            availableDaysOff = availableDaysOff - numberDaysOff; 
        }


        public void AddNewLeave(Leave leave)
        {
            try
            {
                if (availableDaysOff < leave.duration)
                {
                    throw (new NegativeLeaveDaysException ());
                }
                else
                {
                    substractDays(leave.duration);
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

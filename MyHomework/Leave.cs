using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    public class Leave 
    {
        public string stratingDate;
        public int duration;
        public string leaveType;
        public Employee employee;

        public Leave(string startDate, int durationLeave, string type)
        {
            stratingDate = startDate;
            duration = durationLeave;
            leaveType = type;
                 
        }




        

        

    }
}

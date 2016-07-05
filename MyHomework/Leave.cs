using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{

    public enum leaveType
    {
        medical,
        holiday,
        other
    };

    public class Leave 
    {
        internal DateTime stratingDate;
        readonly public int duration;
        public Employee employee;
        private readonly leaveType leaveType;

        public Leave(DateTime startDate, int durationLeave, leaveType type)
        {
            stratingDate = startDate;
            duration = durationLeave;
            leaveType = type;

                 
        }
        
              

    }
}

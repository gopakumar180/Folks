using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagement.Models
{
    public class TimeSheet
    {
        public int empNo;
        public DateTime startDate;
        public DateTime endDate;
        public int sunday;
        public int monday;
        public int tuesday;
        public int wednesday;
        public int thursday;
        public int friday;
        public int saturday;
        public int totalHour;

    }
   /* public class TimeSheet(int empNo, int startDate, int endDate, int sunday, int monday,
        int tuesday, int wednesday, int thursday, int friday, int saturday)
    {

    }*/


}
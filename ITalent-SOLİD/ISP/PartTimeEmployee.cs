using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITalent_SOLİD.ISP
{
    internal class PartTimeEmployee : IEmployee,IPartTimeSalary
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int HourlySalary { get; set; }
        public int TotalHours { get; set; }

        public int CalculateWorkedSalary()
        {
            return HourlySalary * TotalHours;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITalent_SOLİD.ISP
{
    internal interface IPartTimeSalary : IEmployee
    {
        int HourlySalary { get; set; }
        int TotalHours { get; set; }
        public int CalculateWorkedSalary();

    }
}

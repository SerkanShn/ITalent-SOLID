using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITalent_SOLİD.ISP
{
    internal interface IFullTimeSalary : IEmployee
    {
        int Salary { get; set; }
        int Prize { get; set; }
        public int CalculateSalary();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITalent_SOLİD.ISP
{
    internal class FullTimeEmployee : IEmployee , IFullTimeSalary
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Salary { get; set; }
        public int Prize { get; set; }
        
        public int CalculateSalary()
        {
            return Salary + Prize;
        }
    }
}

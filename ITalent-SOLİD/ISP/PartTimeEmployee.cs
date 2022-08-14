using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITalent_SOLİD.ISP
{
    internal class PartTimeEmployee : IEmployee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Salary { get; set; }
        public int Prize { get; set; }
        public int HourlySalary { get; set; }
        public int TotalHours { get; set; }

        public int CalculateSalary()
        {
            throw new NotImplementedException();
        }

        public int CalculateWorkedSalary()
        {
            return HourlySalary * TotalHours;
        }
    }
}

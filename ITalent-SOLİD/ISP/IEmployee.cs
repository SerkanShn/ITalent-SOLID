using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITalent_SOLİD.ISP
{
    internal interface IEmployee
    {
        string Name { get; set; }
        string Surname { get; set; }
        int Salary { get; set; }
        int Prize { get; set; }
        int HourlySalary { get; set; }
        int TotalHours { get; set; }
        public int CalculateSalary();
        public int CalculateWorkedSalary();


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITalent_SOLİD.LSP
{
    internal class Mercedes : Car,IClimate,ISunroof
    {
        public void OpenClimate()
        {
            Console.WriteLine("Klima açıldı");
        }

        public void OpenSunroof()
        {
            Console.WriteLine("Sunroof açıldı");
        }
    }
}

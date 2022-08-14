using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITalent_SOLİD.LSP
{
    internal class Mercedes : Car
    {
        public override void OpenClimate()
        {
            Console.WriteLine("Klima açıldı");
        }

        public override void OpenSunroof()
        {
            Console.WriteLine("Sunroof açıldı");
        }
    }
}

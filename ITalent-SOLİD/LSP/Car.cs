using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITalent_SOLİD.LSP
{
    abstract class Car
    {
        public int carSpeed { get; set; }
        public int carVelocity { get; set; }
        public int carYear { get; set; }

        public void StartEngine()
        {
            Console.WriteLine("Motor çalıştırıldı");
        }

        public void StopEngine()
        {
            Console.WriteLine("Motor durduruldu");
        }

    }
}

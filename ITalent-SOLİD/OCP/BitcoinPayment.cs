using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITalent_SOLİD.OCP
{
    internal class BitcoinPayment : IPaymentMethod
    {
        public string MakePayment()
        {
            return "Bitcoin ile ödemesi yapıldı.";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITalent_SOLİD.OCP
{
    internal class TransferPayment : IPaymentMethod
    {
        public string MakePayment()
        {
            return "Transfer yöntemi ile ödemesi yapıldı.";
        }

    }
}

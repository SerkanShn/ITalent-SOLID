using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITalent_SOLİD.OCP
{
    internal class PaymentManager
    {
        CashPayment cashPayment = new CashPayment();
        CreditCardPayment creditCardPayment = new CreditCardPayment();
        TransferPayment transferPayment = new TransferPayment();
        public string MakeThePayment(string type) => type switch
        {
            "cash" => cashPayment.MakePayment(),
            "creditcard" => creditCardPayment.MakePayment(),
            "transfer" => transferPayment.MakePayment(),
        };

    }
}

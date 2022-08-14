﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITalent_SOLİD.OCP
{
    internal class PaymentManager
    {
        IPaymentMethod paymentMethod;

        public PaymentManager(IPaymentMethod paymentMethod)
        {
            this.paymentMethod = paymentMethod;
        }

        public string MakeThePayment() 
        {
            return paymentMethod.MakePayment();
        }

    }
}

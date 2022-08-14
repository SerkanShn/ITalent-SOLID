﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITalent_SOLİD.DIP
{
    internal class Customer
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Address { get; set; }
        public Contact Contact { get; set; }
        public Order Order { get; set; }

        public void GiveOrder(Order order,Customer customer)
        {
            EmailSender emailSender = new EmailSender();
            SmsSender smsSender = new SmsSender();
            emailSender.MailSend(order, customer);
            smsSender.SmsSend(order, customer);
        }
    }
}

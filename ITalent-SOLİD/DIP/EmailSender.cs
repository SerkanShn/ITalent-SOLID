using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITalent_SOLİD.DIP
{
    internal class EmailSender : INotificationSender
    {

        public void SendNotification(Order order, Customer customer)
        {
            Console.WriteLine($"Sayın {customer.Name}-{customer.SurName} {order.OrderId} no'lu {order.Name} siparişiniz gönderilmiştir. Bu bildirim {customer.Contact.Email} isimli emailinize mail olarak gönderilmiştir.");
        }

    }
}

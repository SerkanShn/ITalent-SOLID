using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITalent_SOLİD.DIP
{
    internal interface INotificationSender
    {
        public void SendNotification(Order order, Customer customer);
    }
}

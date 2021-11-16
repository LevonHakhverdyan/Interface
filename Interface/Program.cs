using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessage email = new Email();
            Notification notificationEmail = new Notification(email);
            IMessage envelop = new Envelop();
            Notification notificationEnvelop = new Notification(envelop);
            IMessage mms = new MMS();
            Notification notificationMMS = new Notification(mms);
            IMessage sms = new SMS();
            Notification notificationSMS = new Notification(sms);

            List<Notification> notifications = new List<Notification>();
            

            notifications.Add(notificationEmail);
            notifications.Add(notificationEnvelop);
            notifications.Add(notificationMMS);
            notifications.Add(notificationSMS);

            for (int i = 0; i < notifications.Count; i++)
            {
                notifications[i].DoNotifi();
            }
            

            Console.ReadKey();

        }
    }
}

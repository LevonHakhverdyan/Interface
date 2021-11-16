using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Notification
    {
        private readonly IMessage _message;
        public Notification(IMessage message)
        {
            _message = message;
        }
        public void DoNotifi()
        {
            _message.SendMessage();
        }
    }
}

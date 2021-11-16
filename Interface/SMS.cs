using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class SMS : IMessage
    {
        public void SendMessage()
        {
            Console.WriteLine("SMS");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigningWorkﬂowEngine
{
    class WebNotificationChannel : IActivity
    {
        public void Execute(Message message)
        {
            Console.WriteLine("We have a video ready for encoding.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigningWorkﬂowEngine
{
    class ChangeStatus : IActivity
    {
        public void Execute(Message message)
        {
            Console.WriteLine("Status changed . ");
        }
    }
}

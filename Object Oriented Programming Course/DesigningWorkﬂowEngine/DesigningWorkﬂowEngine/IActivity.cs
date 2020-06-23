using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigningWorkﬂowEngine
{
    public interface IActivity
    {
        void Execute(Message message);
    }
}

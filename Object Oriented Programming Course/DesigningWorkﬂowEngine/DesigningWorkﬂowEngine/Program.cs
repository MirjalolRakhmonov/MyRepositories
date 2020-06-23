using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigningWorkﬂowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflowEngine = new WorkﬂowEngine();
            workflowEngine.ApplyNotificationChannel(new VideoUploader());
            workflowEngine.ApplyNotificationChannel(new WebNotificationChannel());
            workflowEngine.ApplyNotificationChannel(new MailNotificationChannel());
            workflowEngine.ApplyNotificationChannel(new ChangeStatus());
            workflowEngine.Run(new Video());
        }
    }
}

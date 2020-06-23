using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigningWorkﬂowEngine
{
    class WorkﬂowEngine
    {
        //private readonly MailService _mailService;
        private readonly IList<IActivity> _notificationChannels;

        public WorkﬂowEngine()
        {
            //_mailService = new MailService();
            _notificationChannels = new List<IActivity>();
        }

        public void Run(Video video)
        {
            //_mailService.Send(new Mail());
            foreach (IActivity channel in _notificationChannels)
            {
                channel.Execute(new Message());
            }
        }

        public void ApplyNotificationChannel(IActivity channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}

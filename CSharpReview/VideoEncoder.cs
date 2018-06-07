using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    public class VideoEncoder
    {
        // this creates a tight coupling to MailService
        // should use Interface in the constructor
        // should reduce impact of change in software
        // if there is potential for change should use Open-Close Principle
        // should think in abstractions, like NotificationChannel
        //private readonly MailService _mailService;

        private readonly IList<INotificationChannel> _notificationChannels;

        public VideoEncoder()
        {
            //_mailService = new MailService();
            _notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            // Video encoding logic
            // ...

            //_mailService.Send(new Mail());

            foreach (var channel in _notificationChannels)
            {
                // at run time, different concrete classes / methods are called
                // based on class in list
                channel.Send(new Message());
            }
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_6.InterfaceAndPolymorphism
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannel;

        public VideoEncoder()
        {
            _notificationChannel = new List<INotificationChannel>();
        }
        public void Encode(Video video)
        {
            foreach (var channel in _notificationChannel)
                channel.Send(new Message());
        }

        public void RegistrationNotification(INotificationChannel channel)
        {
            _notificationChannel.Add(channel);
        }
    }
}

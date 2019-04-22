using System;
namespace Selection_6.InterfaceAndPolymorphism
{
    public class SmsNotificationChannel : INotificationChannel
    {
        void INotificationChannel.Send(Message message)
        {
            Console.WriteLine("Sending sms");
        }
    }
}

using System;
namespace Selection_6.InterfaceAndPolymorphism
{
    public class MailNotification : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending mail ....");
        }
    }
}

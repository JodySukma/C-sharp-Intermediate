using Selection_6.InterfaceAndPolymorphism;
using Selection_6.InterfaceAndTestbility;
using Selection_6.InterfacesAndExtensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Example Testibility");
            //var orderProcessor = new OrderProcessor(new ShippingCalculator());
            //var order = new Order { DatePlace = DateTime.Now, TotalPrice = 100f };
            //orderProcessor.Process(order);

            //Console.WriteLine("========================");
            //Console.WriteLine("Example Extensibility");
            //var dbMigrator = new DbMigrator(new FileLogger(@"E:\Pelatihan\log.txt"));
            //dbMigrator.Migrate();

            Console.WriteLine("========================");
            Console.WriteLine("Example Interface and Polymorphism");
            var encoder = new VideoEncoder();
            encoder.RegistrationNotification(new MailNotification());
            encoder.RegistrationNotification(new SmsNotificationChannel());
            encoder.Encode(new Video());

            Console.ReadKey();
        }
    }
}

using Selection_3.ComposisionExam;
using System;

namespace Selection_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example Inheritance");
            var text = new Text();
            text.Width = 100;
            text.Copy();

            Console.WriteLine("==================");
            Console.WriteLine("Example Composition");
            var dbmigrator = new DBMigrator(new Logger());
            var logger = new Logger();
            var installer = new Installer(logger);

            dbmigrator.Migrate();
            installer.Install();
        }
    }
}

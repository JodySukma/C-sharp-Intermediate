using System;
using Selection_6.InterfacesAndExtensibility;

namespace Selection_6.InterfacesAndExtensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migrate started at {0}" + DateTime.Now);

            // details of migrating the database
            _logger.LogInfo("Migrate finished at {0}" + DateTime.Now);
        }
    }
}

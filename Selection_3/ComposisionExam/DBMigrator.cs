namespace Selection_3.ComposisionExam
{
    public class DBMigrator
    {
        private readonly Logger _logger;

        public DBMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migrating bla bla bla...");
        }
    }
}

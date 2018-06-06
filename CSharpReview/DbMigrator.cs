using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        // Dependency Injection w/ Interface in Constructor
        // No coupling between DbMigrator and concrete Logger implementation
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo($"Migratation started at {DateTime.Now}");

            // details of migrating the database

            _logger.LogInfo($"Migration finished at {DateTime.Now}");
        }
    }
}

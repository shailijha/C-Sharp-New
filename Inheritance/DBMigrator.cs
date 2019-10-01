using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
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
            _logger.Log("We are migrating");
        }
    }

}

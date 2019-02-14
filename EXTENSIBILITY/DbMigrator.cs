using System;

namespace EXTENSIBILITY
{
    public class DbMigrator
    {
        //injection des données par constructeur
        private readonly ILogger logger;
        public DbMigrator(ILogger loggerVal)
        {
            this.logger = loggerVal;
        }
        public void Migrated()
        {
            logger.LogInfo("Migrated starting at {0}"+ DateTime.Now);
            //Console.WriteLine("Migrated starting at {0}", DateTime.Now);
            //Details
            
            logger.logError("Migrated finished at {0}"+ DateTime.Now);
            //Console.WriteLine("Migrated finished at {0}", DateTime.Now);
        }


    }
}

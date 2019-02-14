using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXTENSIBILITY
{

    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrated = new DbMigrator(new ConsoleLogger());
            dbMigrated.Migrated();
            System.Console.ReadKey();
        }
    }
}

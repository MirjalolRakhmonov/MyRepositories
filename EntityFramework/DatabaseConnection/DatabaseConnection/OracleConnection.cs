using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string newConnectionString)
            : base(newConnectionString)
        {
            
        }

        public override void OpeningConnection()
        {
            Console.WriteLine("Opening connection ");
        }

        public override void ClosingConnection()
        {
            Console.WriteLine("Closing connection ");
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    class SqlConnection : DbConnection
    {
        public SqlConnection(string newConnectionString)
            :base(newConnectionString)
        {
            
        }
        public override void OpeningConnection()
        {
            Console.WriteLine("Opening connection ");
        }

        public override void ClosingConnection()
        {
            Console.WriteLine("Closing connection ");
        }
    }
}

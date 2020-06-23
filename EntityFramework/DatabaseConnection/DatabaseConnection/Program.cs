using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var oracle = new OracleConnection("Let`s start Oracle Connection ! ");
            oracle.OpeningConnection();
            oracle.ClosingConnection();

            var sql = new SqlConnection("Let`s start SQL Connection !");
            sql.OpeningConnection();
            sql.ClosingConnection();
        }
    }
}

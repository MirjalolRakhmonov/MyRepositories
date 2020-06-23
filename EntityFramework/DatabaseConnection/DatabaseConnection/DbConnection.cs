using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    public abstract class DbConnection
    {
        private string _connectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string newConnectionString)
        {
            if (String.IsNullOrWhiteSpace(newConnectionString))
                throw new InvalidOperationException("Connection string cannot be empty or null , sorry .");
            else
            _connectionString = newConnectionString;
        }

        public abstract void OpeningConnection();
        public abstract void ClosingConnection();
    }
}

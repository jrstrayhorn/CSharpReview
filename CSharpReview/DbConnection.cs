using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentNullException();
            }

            ConnectionString = connectionString;
        }

        public abstract void Open();

        public abstract void Close();
    }
}

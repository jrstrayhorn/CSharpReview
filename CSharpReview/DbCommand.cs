using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    class DbCommand
    {
        DbConnection _dbConnection;

        string _command;

        public DbCommand(DbConnection dbConnection, string command)
        {
            _dbConnection = dbConnection ?? throw new ArgumentNullException();

            if (String.IsNullOrWhiteSpace(command))
            {
                throw new ArgumentNullException();
            }

            _command = command;
        }

        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine($"Running: {_command}");
            _dbConnection.Close();
        }
    }
}

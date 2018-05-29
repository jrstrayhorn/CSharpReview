using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlCommand = new DbCommand(new SqlConnection("sql connection string"), "select * from Customer");
            sqlCommand.Execute();

            var oracleCommand = new DbCommand(new OracleConnection("oracle connection string"), "select * from odbs.Members");
            oracleCommand.Execute();
        }
    }
}

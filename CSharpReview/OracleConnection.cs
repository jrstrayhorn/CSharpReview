﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Close()
        {
            Console.WriteLine("Closing Oracle connection...");
        }

        public override void Open()
        {
            Console.WriteLine("Opening Oracle connection...");
        }
    }
}

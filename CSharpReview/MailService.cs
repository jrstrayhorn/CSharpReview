using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    public class MailService
    {
        // Event Handler
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MailSerivce: Sending an email...");
        }
    }
}

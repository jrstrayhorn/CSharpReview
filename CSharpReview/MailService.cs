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
        //public void OnVideoEncoded(object source, EventArgs e)
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"MailSerivce: Sending an email... {e.Video.Title}");
        }
    }
}

using System;

namespace CSharpReview
{
    public class SendEmailActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Send email to owner of video...");
        }
    }
}

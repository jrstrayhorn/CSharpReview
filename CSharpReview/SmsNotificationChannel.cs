using System;

namespace CSharpReview
{
    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending SMS..");
        }
    }
}

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
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder();  // publisher

            var mailService = new MailService(); // subscriber
            var messageService = new MessageService(); // subscriber


            // VideoEncoded is a list of pointers to event handler methods
            // setting up subscription
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // adding reference to the method
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}

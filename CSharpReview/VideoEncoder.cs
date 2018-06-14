using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpReview
{
    public class VideoEncoder
    {
        // #1 Define delegate, contract/agreement between subscriber and publisher
        // #2 Define event based on the delegate
        // #3 Rasie/publish the event

            // our delegate that holds pointer to method
            // that has return type of void with 2 parameters
            // 1 - object that is source
            // 2 - EventArgs any additional event data
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        public event VideoEncodedEventHandler VideoEncoded;  // past tense for after encoding is done

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video..");
            Thread.Sleep(3000);

            OnVideoEncoded(); // will notify all subscriber
        }

        // Event Publishing Event
        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}

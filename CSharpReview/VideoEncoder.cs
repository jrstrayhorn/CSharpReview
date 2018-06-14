using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpReview
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        // #1 Define delegate, contract/agreement between subscriber and publisher
        // #2 Define event based on the delegate
        // #3 Rasie/publish the event

        // our delegate that holds pointer to method
        // that has return type of void with 2 parameters
        // 1 - object that is source
        // 2 - EventArgs any additional event data
        //public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        //public event VideoEncodedEventHandler VideoEncoded;  // past tense for after encoding is done

        // EventHandler, EventHandler<TEventArgs> is a built in .NET delegate

        public event EventHandler<VideoEventArgs> VideoEncoded; // same as creating our own

        // or use public event EventHandler VideoEncoded; // if dont need custom Event Args
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video..");
            Thread.Sleep(3000);

            OnVideoEncoded(video); // will notify all subscriber
        }

        // Event Publisher Raised Event
        protected virtual void OnVideoEncoded(Video video)
        {
            // OLD WAY of invoking event
            //if (VideoEncoded != null)
            //{
            //    //VideoEncoded(this, EventArgs.Empty);
            //    VideoEncoded(this, new VideoEventArgs() { Video = video });
            //}

            //VideoEncoded(this, EventArgs.Empty);
            VideoEncoded?.Invoke(this, new VideoEventArgs() { Video = video });
        }
    }
}

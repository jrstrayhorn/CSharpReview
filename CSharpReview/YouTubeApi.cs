using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // access youtube web service
                // read the data
                // create a list of video objects
                throw new Exception("OOps some low level YouTube error.");
            }
            catch (Exception ex)
            {
                // Log

                throw new YouTubeException("Could not fetch the videos from YouTube.", ex);
            }

            return new List<Video>();
        }
    }
}

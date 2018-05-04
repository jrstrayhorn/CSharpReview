using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    public class Post
    {
        public int Votes { get; private set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; } = DateTime.Now;

        public void UpVote()
        {
            Votes++;
        }

        public void DownVote()
        {
            Votes--;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    public class Stopwatch
    {
        private bool _isStarted;
        private DateTime _start;
        private DateTime _end;

        public Stopwatch()
        {
            _isStarted = false;
            _start = DateTime.MinValue;
            _end = DateTime.MinValue;
        }

        public string Duration
        {
            get { return _end.Subtract(_start).ToString(@"h\:mm\:ss"); }
        }

        public void Start()
        {
            if (_isStarted)
            {
                throw new InvalidOperationException("Stopwatch is already started.");
            }

            _isStarted = true;
            _start = DateTime.Now;
        }

        public void Stop()
        {
            if (_isStarted)
            {
                _isStarted = false;
                _end = DateTime.Now; 
            }
        }
    }
}

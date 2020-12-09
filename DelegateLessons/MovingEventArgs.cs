using System;

namespace DelegateLessons
{
    public class MovingEventArgs:EventArgs
    {
        public MovingEventArgs()
        {
        }

        public MovingEventArgs(string message)
        {
            Message = message;
        }

        public string Message { get; private set; }
    }
}
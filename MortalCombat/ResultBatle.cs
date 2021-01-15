using System;

namespace MortalCombat
{
    public class ResultBatle : EventArgs
    {
        public string Message { get; private set; }

        public ResultBatle() { }
        public ResultBatle(string message)
        {
            Message = message;
        }

    }
}
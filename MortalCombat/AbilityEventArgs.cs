using System;

namespace MortalCombat
{
    public class AbilityEventArgs: EventArgs
    {
        public string Message { get; private set; }

        public AbilityEventArgs() { }
        public AbilityEventArgs(string message)
        {
            Message = message;
        }

    }
}
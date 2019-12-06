using System;
using System.Runtime.Serialization;

namespace FordProgBeadando
{
    [Serializable]
    internal class TerminalSymbolNotFoundException : Exception
    {
        public TerminalSymbolNotFoundException()
        {
        }

        public TerminalSymbolNotFoundException(string message) : base(message)
        {
        }

        public TerminalSymbolNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TerminalSymbolNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
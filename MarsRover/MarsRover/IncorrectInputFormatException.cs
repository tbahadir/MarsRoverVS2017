using System;
using System.Runtime.Serialization;

namespace MarsRover
{
    [Serializable]
    internal class IncorrectInputFormatException : Exception
    {
        public IncorrectInputFormatException()
        {
            Console.WriteLine(typeof(IncorrectInputFormatException));
            Console.ReadLine();
        }

        public IncorrectInputFormatException(string message) : base(message)
        {
        }

        public IncorrectInputFormatException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IncorrectInputFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
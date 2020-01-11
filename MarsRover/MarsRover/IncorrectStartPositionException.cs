using System;
using System.Runtime.Serialization;

namespace MarsRover
{
    [Serializable]
    internal class IncorrectStartPositionException : Exception
    {
        public IncorrectStartPositionException()
        {
            Console.WriteLine(typeof(IncorrectStartPositionException));
            Console.ReadLine();
        }

        public IncorrectStartPositionException(string message) : base(message)
        {
        }

        public IncorrectStartPositionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IncorrectStartPositionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
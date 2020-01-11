using System;
using System.Runtime.Serialization;

namespace MarsRover
{
    [Serializable]
    internal class IncorrectPlateauDimensionsException : Exception
    {
        public IncorrectPlateauDimensionsException()
        {
            Console.WriteLine(typeof(IncorrectPlateauDimensionsException));
            Console.ReadLine();
        }

        public IncorrectPlateauDimensionsException(string message) : base(message)
        {
        }

        public IncorrectPlateauDimensionsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IncorrectPlateauDimensionsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
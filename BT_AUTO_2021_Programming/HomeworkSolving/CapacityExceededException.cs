using System;
using System.Runtime.Serialization;

namespace BT_AUTO_2021_Programming.HomeworkSolving
{
    [Serializable]
    internal class CapacityExceededException : Exception
    {
        public CapacityExceededException()
        {
        }

        public CapacityExceededException(string message) : base(message)
        {
            Console.WriteLine("The Capacity exceed!!! Please create a building with fewer room capacity!");
        }

        public CapacityExceededException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CapacityExceededException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
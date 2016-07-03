using System;
using System.Runtime.Serialization;

namespace MyHomework
{
    [Serializable]
    internal class NegativeLeaveDaysException : Exception
    {
        public NegativeLeaveDaysException()
        {
        }

        public NegativeLeaveDaysException(string message) : base(message)
        {
            //Console.WriteLine("Numarul de zile ramase nu poate fi mai mare decat durata concediului");
        }

        public NegativeLeaveDaysException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NegativeLeaveDaysException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
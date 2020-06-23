using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    [Serializable]
    public class InvalidAnimalException : Exception
    {
        public InvalidAnimalException()
        {
        }

        public InvalidAnimalException(string message) : base(message)
        {
        }

        public InvalidAnimalException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidAnimalException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

using System.Runtime.Serialization;

namespace Shop.domain.exceptions
{
    [Serializable]
    internal class InvalidContactException : Exception
    {
        public InvalidContactException() { }
        public InvalidContactException(String? message) : base(message) { }
        public InvalidContactException(String? message, Exception? innerException) : base(message, innerException) { }
        protected InvalidContactException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
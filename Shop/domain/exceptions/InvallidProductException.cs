using System.Runtime.Serialization;

namespace Shop.domain.exceptions
{
    [Serializable]
    internal class InvalidProductException : Exception
    {
        public InvalidProductException() { }
        public InvalidProductException(String? message) : base(message) { }
        public InvalidProductException(String? message, Exception? innerException) : base(message, innerException) { }
        protected InvalidProductException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}